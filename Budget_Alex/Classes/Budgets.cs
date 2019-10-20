using Budget_Alex.DataEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Budget_Alex.Classes
{
    public class Budgets
    {
        //Db context
        protected BudgetEntitiesConn DbContext;

        //Data list Budget
        public List<Budget> DataSource { get; set; }
        //Liste column
        public List<string> ColumnNames { get; set; }

        //Budget calculed
        public List<BudgetResult> GetBudgetResult { get; set; }

        public BudgetResult BudgetCalculed { get; set; }
        public BudgetResult BudgetCalculedFiltred { get; set; }


        //used in tangent with update method
        public string ValidationMessage { get; set; }
        public int NewIdentifier { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Budgets()
        {
            //init db context
            DbContext = new BudgetEntitiesConn();

            //Load budget
            GetBudgets();

            //Calcul budget
            CalResultBudgets();

            //Init grid column
            GetColumNames();
        }

        /// <summary>
        /// Load and get Budgte list
        /// </summary>
        public void GetBudgets()
        {
            using (DbContext = new BudgetEntitiesConn())
            {
                try
                {
                    DataSource = DbContext.Budget.Select(cust => cust)
                        .Distinct()
                        .OrderByDescending(cust => cust.Id)
                        .ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Calcul Summe per ein / aus gaben.
        /// </summary>
        public void CalResultBudgets()
        {
            using (DbContext = new BudgetEntitiesConn())
            {
                try
                {
                    double resEin = 0;
                    double resAus = 0;
                    double resDif = 0;

                    foreach (Budget valBudget in DbContext.Budget)
                    {
                        if ((bool)valBudget.IsEin)
                        {
                            resEin += valBudget.Summe;
                        }
                        else
                        {
                            resAus += valBudget.Summe;
                        }
                    }

                    if (resAus > 0 && resEin > 0)
                    {
                        resDif = (resEin - resAus);
                    }

                    BudgetCalculed = new BudgetResult()
                    {
                        SummeAus = resAus,
                        SummeEin = resEin,
                        SummeDiff = resDif,
                        DateCreate = DateTime.Now,
                    };


                    GetBudgetResult = new List<BudgetResult>();
                    BudgetResult valCalculed = new BudgetResult()
                    {
                        SummeAus = resAus,
                        SummeEin = resEin,
                        SummeDiff = resDif,
                        DateCreate = DateTime.Now,
                    };

                    GetBudgetResult.Add(valCalculed);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        /// <summary>
        /// Shows how to get column names for budget table
        /// </summary>
        /// <remarks>Hard coded to the current model and Customer entity.</remarks>
        private void GetColumNames()
        {
            ColumnNames = new List<string>();
            using (DbContext = new BudgetEntitiesConn())
            {
                var objectContext = ((IObjectContextAdapter)DbContext).ObjectContext;
                var storageMetadata = ((EntityConnection)objectContext.Connection).GetMetadataWorkspace().GetItems(DataSpace.SSpace);
                var entityProps = (from sm in storageMetadata where sm.BuiltInTypeKind == BuiltInTypeKind.EntityType select sm as EntityType);

                // For your project, open the model browser to get the name for the model, will have namespace.Store
                var metaData = (from m in entityProps where m.FullName == "NORTHWNDModel.Store.Budget" select m.DeclaredProperties).ToList();

                foreach (var topItem in metaData)
                {
                    foreach (var item in topItem)
                    {
                        ColumnNames.Add(item.Name);
                    }
                }
            }
        }

        #region Budget Crud


        /// <summary>
        /// Remove new version
        /// </summary>
        /// <param name="sender"></param>
        public void RemoveBudget(DataEntity.Budget sender)
        {
            using (BudgetEntitiesConn DbContext = new BudgetEntitiesConn())
            {
                DbContext.Entry(sender).State = EntityState.Deleted;
                DbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update new version
        /// </summary>
        /// <param name="editedCustomer"></param>
        /// <returns></returns>
        public bool UpdateBudget(DataEntity.Budget editBudget)
        {
            using (BudgetEntitiesConn DbContext = new BudgetEntitiesConn())
            {
                try
                {
                    DbContext.Entry(editBudget).State = EntityState.Modified;
                    DbContext.SaveChanges();
                    ValidationMessage = "";
                    return true;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ef)
                {
                    UndoPendingChanges(DbContext);
                    ValidationMessage = ef.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    UndoPendingChanges(DbContext);
                    ValidationMessage = "Update fehlgeschlagen " + Environment.NewLine + ex.Message+ 
                                        Environment.NewLine + ex.StackTrace +
                                        Environment.NewLine + ex.InnerException;
                    return false;
                }
            }
        }

        /// <summary>
        /// Add customer new version
        /// </summary>
        /// <param name="newbBudget">budget objkect</param>
        /// <returns></returns>
        public bool AddBudget(Budget newbBudget)
        {
            using (BudgetEntitiesConn DbContext = new BudgetEntitiesConn())
            {
                try
                {
                    DbContext.Budget.Add(newbBudget);

                    DbContext.SaveChanges();

                    NewIdentifier = newbBudget.Id;

                    ValidationMessage = "";

                    return true;

                }
                catch (Exception ex)
                {
                    ValidationMessage = "Hinzufügen neuen Budgets ist fehlgeschlagen " + ex.Message + Environment.NewLine + ex.StackTrace;

                    return false;
                }
            }
        }


        public static void UndoPendingChanges(DbContext context)
        {
            //detect all changes (probably not required if AutoDetectChanges is set to true)
            context.ChangeTracker.DetectChanges();

            //get all entries that are changed
            var entries = context.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged).ToList();

            //somehow try to discard changes on every entry
            foreach (var dbEntityEntry in entries)
            {
                var entity = dbEntityEntry.Entity;

                if (entity == null) continue;

                if (dbEntityEntry.State == EntityState.Added)
                {
                    //if entity is in Added state, remove it.
                    var set = context.Set(entity.GetType());
                    set.Remove(entity);
                }
                else if (dbEntityEntry.State == EntityState.Modified)
                {
                    //entity is modified... you can set it to Unchanged or Reload it form Db??
                    dbEntityEntry.Reload();
                }
                else if (dbEntityEntry.State == EntityState.Deleted)
                    //entity is deleted...
                    dbEntityEntry.State = EntityState.Modified;
            }
        }

        #endregion

        #region Search Budget


        /// <summary>
        /// Load budget and filter with parameter
        /// </summary>
        /// <param name="parName">name</param>
        /// <param name="parJahr">jahr</param>
        /// <param name="parMonate">monate</param>
        /// <param name="parType">ein or aus</param>
        /// <param name="parIsMonate">Monatliche</param>
        public void SerachValueFilter(string parName, string parJahr, string parMonate, string parType, string parIsMonate, string parUser)
        {
            using (BudgetEntitiesConn DbContext = new BudgetEntitiesConn())
            {
                //Load all budget
                DbQuery<Budget> budgetWhere = DbContext.Budget;

                var valParamTxt = string.Empty;

                var valParam = 0;
                var valParam1 = 0;
                var valParamBool = false;
                var valParamBool1 = false;

                if (!string.IsNullOrEmpty(parName))
                {
                    budgetWhere = (DbQuery<Budget>)budgetWhere.Where(c => c.Name.ToLower().Contains(parName.ToLower()));
                }

                if (!string.IsNullOrEmpty(parJahr))
                {
                    valParam = short.Parse(parJahr);
                    budgetWhere = (DbQuery<Budget>)budgetWhere.Where(c => c.Jahr == valParam);
                }

                if (!string.IsNullOrEmpty(parUser))
                {
                    valParamTxt = parUser;
                    budgetWhere = (DbQuery<Budget>)budgetWhere.Where(c => c.UserBudget == valParamTxt);
                }


                if (!string.IsNullOrEmpty(parMonate))
                {
                    valParam1 = short.Parse(parMonate);
                    budgetWhere = (DbQuery<Budget>)budgetWhere.Where(c => c.Monate == valParam1);
                }

                if (!string.IsNullOrEmpty(parType))
                {
                    valParamBool = Convert.ToBoolean(parType);
                    budgetWhere = (DbQuery<Budget>)budgetWhere.Where(c => c.IsEin == valParamBool);
                }

                if (!string.IsNullOrEmpty(parIsMonate))
                {
                    valParamBool1 = Convert.ToBoolean(parIsMonate);
                    budgetWhere = (DbQuery<Budget>)budgetWhere.Where(c => c.IsFixe == valParamBool1);

                }

                //Set dat object
                DataSource = budgetWhere.ToList();

                //Cacul budget filtred
                CalResultBudgetsFilter(DataSource);
            }
        }


        public void CalResultBudgetsFilter(List<Budget> lisBudgetSearch)
        {
            if (lisBudgetSearch.Count > 0)
            {
                double resEin = 0;
                double resAus = 0;
                double resDif = 0;

                foreach (Budget valBudget in lisBudgetSearch)
                {
                    if ((bool)valBudget.IsEin)
                    {
                        resEin += valBudget.Summe;
                    }
                    else
                    {
                        resAus += valBudget.Summe;
                    }
                }

                if (resAus > 0 && resEin > 0)
                {
                    resDif = (resEin - resAus);
                }

                BudgetCalculedFiltred = new BudgetResult()
                {
                    SummeAus = resAus,
                    SummeEin = resEin,
                    SummeDiff = resDif,
                    DateCreate = DateTime.Now,
                };
              
            }
        }
        
        #endregion
        
    }
}
