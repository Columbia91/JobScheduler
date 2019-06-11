using JobScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace JobScheduler.DataAccess
{
    public class TasksTableDataService
    {
        public void InsertTask(Task task)
        {
            using(var context = new JobContext())
            {
                try
                {
                    context.Tasks.Add(task);
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
