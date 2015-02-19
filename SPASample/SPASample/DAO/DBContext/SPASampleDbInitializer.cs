using SPASample.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPASample.DAO.DBContext
{
    public class SPASampleDbInitializer: CreateDatabaseIfNotExists<SPASampleDbContext>
    {
        protected override void Seed(SPASampleDbContext context)
        {
            var screens = new List<Screen>{
            new Screen { Name = "EPAY", Title = "Employee Payment List", System = ScreenSystem.PAYROLL, LastUpdate = DateTime.Now },
            new Screen { Name = "LHISTORY", Title = "History of Leaves", System = ScreenSystem.HR, LastUpdate = DateTime.Now },
            new Screen { Name = "PHISTORY", Title = "History Payment List", System = ScreenSystem.PAYROLL, LastUpdate = DateTime.Now },
            new Screen { Name = "PARRT", Title = "Payroll Report Status", System = ScreenSystem.PAYROLL, LastUpdate = DateTime.Now }
        };

            foreach (var screen in screens)
            {
                var dbScreen = context.Screen.Where(x => x.Name == screen.Name).FirstOrDefault();
                if (dbScreen == null)
                {
                    context.Screen.Add(screen);
                }
            }

            context.SaveChanges();

            var fields = new List<Field> { 
                            new Field { Name = "_TRANNO", ScreenID = 1, Caption = "TRANNO", Status = FieldStatus.Visible, Tooltip = "Enter transaction number", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANDATE", ScreenID = 1, Caption = "TRANDATE", Status = FieldStatus.Visible, Tooltip = "Transaction date", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANBY", ScreenID = 1, Caption = "TRANBY", Status = FieldStatus.Visible, Tooltip = "Transaction By", LastUpdate = DateTime.Now },
                            new Field { Name = "_AMOUNT", ScreenID = 1, Caption = "AMOUNT", Status = FieldStatus.Visible, Tooltip = "Enter transaction amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_STATUS", ScreenID = 1, Caption = "STATUS", Status = FieldStatus.Visible, Tooltip = "Select status", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANREFNO", ScreenID = 1, Caption = "TRANREFNO", Status = FieldStatus.Hidden, Tooltip = "Transaction refrence no", LastUpdate = DateTime.Now },
                            new Field { Name = "_DESCRIPTION", ScreenID = 1, Caption = "DESCRIPTION", Status = FieldStatus.Hidden, Tooltip = "Enter transaction description", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANTYPE", ScreenID = 1, Caption = "TRANTYPE", Status = FieldStatus.Hidden, Tooltip = "Select transaction type", LastUpdate = DateTime.Now },
                            new Field { Name = "_TAX", ScreenID = 1, Caption = "TAX", Status = FieldStatus.Disabled, Tooltip = "Enter tax", LastUpdate = DateTime.Now },
                            new Field { Name = "_TOTALAMOUNT", ScreenID = 1, Caption = "TOTAL AMOUNT", Status = FieldStatus.Disabled, Tooltip = "Total amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_EMPNAME", ScreenID = 2, Caption = "EMPNAME", Status = FieldStatus.Visible, Tooltip = "Enter employee name", LastUpdate = DateTime.Now },
                            new Field { Name = "_CREATEDATE", ScreenID = 2, Caption = "CREATE DATE", Status = FieldStatus.Visible, Tooltip = "Created date", LastUpdate = DateTime.Now },
                            new Field { Name = "_REASON", ScreenID = 2, Caption = "REASON", Status = FieldStatus.Visible, Tooltip = "Reason of leave", LastUpdate = DateTime.Now },
                            new Field { Name = "_DATEFROM", ScreenID = 2, Caption = "DATEFROM", Status = FieldStatus.Visible, Tooltip = "Enter  start date of leave", LastUpdate = DateTime.Now },
                            new Field { Name = "_DATETO", ScreenID = 2, Caption = "DATETO", Status = FieldStatus.Visible, Tooltip = "Enter last date of leave", LastUpdate = DateTime.Now },
                            new Field { Name = "_STATUS", ScreenID = 2, Caption = "STATUS", Status = FieldStatus.Disabled, Tooltip = "Enter status", LastUpdate = DateTime.Now },
                            new Field { Name = "_APPROVEBY", ScreenID = 2, Caption = "APPROVEDBY", Status = FieldStatus.Disabled, Tooltip = "Select approved by", LastUpdate = DateTime.Now },
                            new Field { Name = "_RESPPERSON", ScreenID = 2, Caption = "RESPPERSON", Status = FieldStatus.Hidden, Tooltip = "Select responsible person", LastUpdate = DateTime.Now },
                            new Field { Name = "_WORKDESCRIPTION", ScreenID = 2, Caption = "WORKDESCRIPTION", Status = FieldStatus.Hidden, Tooltip = "Enter work description", LastUpdate = DateTime.Now },
                            new Field { Name = "_LEAVETYPE", ScreenID = 2, Caption = "LEAVETYPE", Status = FieldStatus.Hidden, Tooltip = "Select leave type", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANNO", ScreenID = 3, Caption = "TRANNO", Status = FieldStatus.Visible, Tooltip = "Enter transaction number", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANDATE", ScreenID = 3, Caption = "TRANDATE", Status = FieldStatus.Disabled, Tooltip = "Transaction date", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANBY", ScreenID = 3, Caption = "TRANBY", Status = FieldStatus.Disabled, Tooltip = "Transaction By", LastUpdate = DateTime.Now },
                            new Field { Name = "_AMOUNT", ScreenID = 3, Caption = "AMOUNT", Status = FieldStatus.Visible, Tooltip = "Enter transaction amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_STATUS", ScreenID = 3, Caption = "STATUS", Status = FieldStatus.Visible, Tooltip = "Select status", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANREFNO", ScreenID = 3, Caption = "TRANREFNO", Status = FieldStatus.Hidden, Tooltip = "Transaction refrence no", LastUpdate = DateTime.Now },
                            new Field { Name = "_DESCRIPTION", ScreenID = 3, Caption = "DESCRIPTION", Status = FieldStatus.Hidden, Tooltip = "Enter transaction description", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANTYPE", ScreenID = 3, Caption = "TRANTYPE", Status = FieldStatus.Hidden, Tooltip = "Select transaction type", LastUpdate = DateTime.Now },
                            new Field { Name = "_TAX", ScreenID = 3, Caption = "TAX", Status = FieldStatus.Visible, Tooltip = "Enter tax", LastUpdate = DateTime.Now },
                            new Field { Name = "_TOTALAMOUNT", ScreenID = 3, Caption = "TOTAL AMOUNT", Status = FieldStatus.Visible, Tooltip = "Total amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANID", ScreenID = 4, Caption = "TRANID", Status = FieldStatus.Visible, Tooltip = "Transaction id", LastUpdate = DateTime.Now },
                            new Field { Name = "_CREATEDDATE", ScreenID = 4, Caption = "CREATEDDATE", Status = FieldStatus.Visible, Tooltip = "Create date", LastUpdate = DateTime.Now },
                            new Field { Name = "_EMPNAME", ScreenID = 4, Caption = "EMPNAME", Status = FieldStatus.Visible, Tooltip = "Enter employee name ", LastUpdate = DateTime.Now },
                            new Field { Name = "_DEPTNAME", ScreenID = 4, Caption = "DEPTNAME", Status = FieldStatus.Visible, Tooltip = "Enter department name", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANTYPE", ScreenID = 4, Caption = "TRANTYPE", Status = FieldStatus.Visible, Tooltip = "Select transaction type", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANBY", ScreenID = 4, Caption = "TRANBY", Status = FieldStatus.Visible, Tooltip = "Transaction by", LastUpdate = DateTime.Now },
                            new Field { Name = "_STATUS", ScreenID = 4, Caption = "STATUS", Status = FieldStatus.Visible, Tooltip = "Select status", LastUpdate = DateTime.Now },
                            new Field { Name = "_TRANREFNO", ScreenID = 4, Caption = "TRANREFNO", Status = FieldStatus.Visible, Tooltip = "Transaction ref no", LastUpdate = DateTime.Now },
                            new Field { Name = "_DUEDATE", ScreenID = 4, Caption = "DUEDATE", Status = FieldStatus.Visible, Tooltip = "Enter due date", LastUpdate = DateTime.Now },
                            new Field { Name = "_BASICSALARY", ScreenID = 4, Caption = "BASICSALARY", Status = FieldStatus.Visible, Tooltip = "Enter basic salary", LastUpdate = DateTime.Now },
                            new Field { Name = "_OVERTIMEAMOUNT", ScreenID = 4, Caption = "OVERTIMEAMOUNT", Status = FieldStatus.Visible, Tooltip = "Enter over time amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_BONUS", ScreenID = 4, Caption = "BONUS", Status = FieldStatus.Hidden, Tooltip = "Enter bonus amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_BONUSDESCRIPTION", ScreenID = 4, Caption = "BONUSDESCRIPTION", Status = FieldStatus.Hidden, Tooltip = "Enter bonus description", LastUpdate = DateTime.Now },
                            new Field { Name = "_RECAMOUNT", ScreenID = 4, Caption = "RECIEVEDAMOUNT", Status = FieldStatus.Disabled, Tooltip = "Recived amount", LastUpdate = DateTime.Now },
                            new Field { Name = "_TAX", ScreenID = 4, Caption = "TAX", Status = FieldStatus.Disabled, Tooltip = "Tax", LastUpdate = DateTime.Now },
                            new Field { Name = "_TOTALAMOUNT", ScreenID = 4, Caption = "TOTALAMOUNT", Status = FieldStatus.Disabled, Tooltip = "Total amount", LastUpdate = DateTime.Now }
            };

            foreach (var field in fields)
            {
                var dbField = context.Field.Where(f => f.ScreenID == field.ScreenID && f.Name == field.Name).FirstOrDefault();
                if (dbField == null)
                {
                    context.Field.Add(field);
                }
            }

            context.SaveChanges();
            base.Seed(context);
        }

    }
}