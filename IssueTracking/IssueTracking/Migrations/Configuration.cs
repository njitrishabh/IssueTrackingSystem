namespace IssueTracking.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IssueTracking.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IssueTracking.Models.IssueDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IssueTracking.Models.IssueDBContext context)
        {
            context.Issues.AddOrUpdate(i => i.Title,
       new Issue
       {
           Title = "Bug",
           Status = "New",
           Description = "Windows Calendar Crashed",
           Severity = "High",
           Asignee = "John",
           DueDate = DateTime.Parse("2017-1-11")  
       },

        new Issue
        {
            Title = "App Slow Performance",
            Status = "In Progress",
            Description = "Boot loading very slow",
            Severity = "Medium",
            Asignee = "Randy",
            DueDate = DateTime.Parse("2017-7-10")
        },

        new Issue
        {
            Title = "Database",
            Status = "Resolved",
            Description = "Update database to trim unused contents",
            Severity = "Low",
            Asignee = "Carlos",
            DueDate = DateTime.Parse("2017-8-12")
        },

      new Issue
      {
          Title = "UI Failure",
          Status = "Closed",
          Description = "Css issues, page doesn't fit on screen",
          Severity = "High",
          Asignee = "Jack",
          DueDate = DateTime.Parse("2017-9-10")
      }
  );
        }
    }
}
