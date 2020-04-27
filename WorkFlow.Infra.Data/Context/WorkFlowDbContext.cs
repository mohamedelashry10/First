using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Domain.Models;

namespace WorkFlow.Infra.Data.Context
{
   public class WorkFlowDbContext : DbContext
    {
        public WorkFlowDbContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<workFlow> WorkFlows { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<OperatorTypes> OperatorTypes { get; set; }
        public virtual DbSet<Step> Steps { get; set; }
        public virtual DbSet<StepAction> StepActions { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<ActionOperator> ActionOperators { get; set; }
        public virtual DbSet<Instance> Instances { get; set; }
        public virtual DbSet<InstanceAction> InstaneActions { get; set; }
    }
}
