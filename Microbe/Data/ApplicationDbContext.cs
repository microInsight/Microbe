using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microbe.Models;
using Microbe.Models.ProjectInformationModels;
using Microbe.Models.ReportModels;
using Microbe.Models.ReportSections;

namespace Microbe.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Microbe.Models.ProjectInformationModels.ClientProjectReports> ClientProjectReports { get; set; }

        public DbSet<Microbe.Models.ProjectInformationModels.ClientProjects> ClientProjects { get; set; }

        public DbSet<Microbe.Models.ReportModels.ProjectReportParameters> ProjectReportParameters { get; set; }

        public DbSet<Microbe.Models.ProjectInformationModels.ProjectReportSampleSelection> ProjectReportSampleSelection { get; set; }

        public DbSet<Microbe.Models.ReportModels.SubReportDefinitions> SubReportDefinitions { get; set; }

        public DbSet<Microbe.Models.ReportModels.ReportDefinitions> ReportDefinitions { get; set; }

        public DbSet<Microbe.Models.ProjectInformationModels.LIMS_Client> LIMS_Client { get; set; }

        public DbSet<Microbe.Models.ProjectInformationModels.LIMS_Branches> LIMS_Branches { get; set; }

        public DbSet<Microbe.Models.ProjectInformationModels.LIMS_ProjectClient> LIMS_ProjectClient { get; set; }

        public DbSet<Microbe.Models.ReportSections.ReportSections> ReportSections { get; set; }

        public DbSet<Microbe.Models.ReportModels.ReportSectionFigures> ReportSectionFigures { get; set; }

        public DbSet<Microbe.Models.ReportModels.ReportTitlePage> ReportTitlePages { get; set; }

        public DbSet<Microbe.Models.ReportModels.NGS_Report> NGS_Report { get; set; }

        public DbSet<Microbe.Models.NGSReportParts.NGS_GenClassificationResultsTable> NGS_GenClassificationResultsTables { get; set; }

        public DbSet<Microbe.Models.NGSReportParts.NGS_ClassificationResults> NGS_ClassificationResults { get; set; }

        public DbSet<Microbe.Models.NGSReportParts.NGS_SampleAggregate> NGS_SampleAggregates { get; set; }

        public DbSet<Microbe.Models.NGSReportParts.NGS_TTLPhylumClassificationResults> NGS_TTLPhylumClassificationResults { get; set; }

        public DbSet<Microbe.Models.NGSReportParts.NGS_Statistics> NGS_Statistics { get; set; }

        public DbSet<Microbe.Models.NGSReportParts.NGS_SampleHits> NGS_SampleHits { get; set; }



    }
}
