using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AtavusUserMatcher.Models;

namespace AtavusUserMatcher.Data
{
    public partial class atavus_dbContext : DbContext
    {
        public atavus_dbContext()
        {
        }

        public atavus_dbContext(DbContextOptions<atavus_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveStorageAttachment> ActiveStorageAttachments { get; set; } = null!;
        public virtual DbSet<ActiveStorageBlob> ActiveStorageBlobs { get; set; } = null!;
        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; } = null!;
        public virtual DbSet<BrandingItem> BrandingItems { get; set; } = null!;
        public virtual DbSet<BrandingItemOrganization> BrandingItemOrganizations { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Certificate> Certificates { get; set; } = null!;
        public virtual DbSet<Chapter> Chapters { get; set; } = null!;
        public virtual DbSet<CoachTip> CoachTips { get; set; } = null!;
        public virtual DbSet<CommonInformationList> CommonInformationLists { get; set; } = null!;
        public virtual DbSet<CommonInformationListDefinition> CommonInformationListDefinitions { get; set; } = null!;
        public virtual DbSet<CommonInformationListItem> CommonInformationListItems { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseInstructor> CourseInstructors { get; set; } = null!;
        public virtual DbSet<CourseRun> CourseRuns { get; set; } = null!;
        public virtual DbSet<CourseVersion> CourseVersions { get; set; } = null!;
        public virtual DbSet<CourseVideo> CourseVideos { get; set; } = null!;
        public virtual DbSet<Enrollment> Enrollments { get; set; } = null!;
        public virtual DbSet<HtmlComponent> HtmlComponents { get; set; } = null!;
        public virtual DbSet<Import> Imports { get; set; } = null!;
        public virtual DbSet<ImportedUser> ImportedUsers { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<Learn> Learns { get; set; } = null!;
        public virtual DbSet<LearnCourseVideo> LearnCourseVideos { get; set; } = null!;
        public virtual DbSet<OembedProvider> OembedProviders { get; set; } = null!;
        public virtual DbSet<OembedResource> OembedResources { get; set; } = null!;
        public virtual DbSet<Organization> Organizations { get; set; } = null!;
        public virtual DbSet<OrganizationCoursePolicy> OrganizationCoursePolicies { get; set; } = null!;
        public virtual DbSet<OrganizationPlan> OrganizationPlans { get; set; } = null!;
        public virtual DbSet<OrganizationPlanCategory> OrganizationPlanCategories { get; set; } = null!;
        public virtual DbSet<OrganizationPlansPlanGuide> OrganizationPlansPlanGuides { get; set; } = null!;
        public virtual DbSet<OrganizationUser> OrganizationUsers { get; set; } = null!;
        public virtual DbSet<Plan> Plans { get; set; } = null!;
        public virtual DbSet<PlanBuilder> PlanBuilders { get; set; } = null!;
        public virtual DbSet<PlanGuide> PlanGuides { get; set; } = null!;
        public virtual DbSet<PlanPrice> PlanPrices { get; set; } = null!;
        public virtual DbSet<Practice> Practices { get; set; } = null!;
        public virtual DbSet<PracticeDrill> PracticeDrills { get; set; } = null!;
        public virtual DbSet<PracticeDrillCategory> PracticeDrillCategories { get; set; } = null!;
        public virtual DbSet<PracticeWeek> PracticeWeeks { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductSku> ProductSkus { get; set; } = null!;
        public virtual DbSet<ProductUser> ProductUsers { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionChoice> QuestionChoices { get; set; } = null!;
        public virtual DbSet<QuestionVersion> QuestionVersions { get; set; } = null!;
        public virtual DbSet<Quiz> Quizzes { get; set; } = null!;
        public virtual DbSet<QuizSubmission> QuizSubmissions { get; set; } = null!;
        public virtual DbSet<QuizVersion> QuizVersions { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; } = null!;
        public virtual DbSet<SeedMigrationDataMigration> SeedMigrationDataMigrations { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<StripeEvent> StripeEvents { get; set; } = null!;
        public virtual DbSet<StudentUnitProgress> StudentUnitProgresses { get; set; } = null!;
        public virtual DbSet<StudentUnitProgressHistory> StudentUnitProgressHistories { get; set; } = null!;
        public virtual DbSet<Subscription> Subscriptions { get; set; } = null!;
        public virtual DbSet<SubscriptionLog> SubscriptionLogs { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserCoupon> UserCoupons { get; set; } = null!;
        public virtual DbSet<UserImportFail> UserImportFails { get; set; } = null!;
        public virtual DbSet<AtavusUserMatcher.Models.Version> Versions { get; set; } = null!;
        public virtual DbSet<Video> Videos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=rds-mysql-prod-2.czlwqatllt62.us-east-2.rds.amazonaws.com;database=atavus_db;uid=root;pwd=rds-mysql-prod-2", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<ActiveStorageAttachment>(entity =>
            {
                entity.ToTable("active_storage_attachments");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.BlobId, "index_active_storage_attachments_on_blob_id");

                entity.HasIndex(e => new { e.RecordType, e.RecordId, e.Name, e.BlobId }, "index_active_storage_attachments_uniqueness")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.BlobId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("blob_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.RecordId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("record_id");

                entity.Property(e => e.RecordType).HasColumnName("record_type");
            });

            modelBuilder.Entity<ActiveStorageBlob>(entity =>
            {
                entity.ToTable("active_storage_blobs");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Key, "index_active_storage_blobs_on_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ByteSize)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("byte_size");

                entity.Property(e => e.Checksum)
                    .HasMaxLength(255)
                    .HasColumnName("checksum");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(255)
                    .HasColumnName("content_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Metadata)
                    .HasColumnType("text")
                    .HasColumnName("metadata");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("answers");

                entity.HasIndex(e => e.QuestionChoiceId, "index_answers_on_question_choice_id");

                entity.HasIndex(e => e.QuizSubmissionId, "index_answers_on_quiz_submission_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.QuestionChoiceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("question_choice_id");

                entity.Property(e => e.QuizSubmissionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("quiz_submission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.QuestionChoice)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionChoiceId)
                    .HasConstraintName("fk_rails_4f0a5b98b0");

                entity.HasOne(d => d.QuizSubmission)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuizSubmissionId)
                    .HasConstraintName("fk_rails_bf4f1e0f48");
            });

            modelBuilder.Entity<ArInternalMetadatum>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PRIMARY");

                entity.ToTable("ar_internal_metadata");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<BrandingItem>(entity =>
            {
                entity.ToTable("branding_items");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .HasColumnName("key");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(255)
                    .HasColumnName("value_type");
            });

            modelBuilder.Entity<BrandingItemOrganization>(entity =>
            {
                entity.ToTable("branding_item_organizations");

                entity.HasIndex(e => new { e.BrandingItemId, e.OrganizationId }, "branding_item_organization_unique_index")
                    .IsUnique();

                entity.HasIndex(e => e.BrandingItemId, "index_branding_item_organizations_on_branding_item_id");

                entity.HasIndex(e => e.OrganizationId, "index_branding_item_organizations_on_organization_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.BrandingItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("branding_item_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.BrandingItem)
                    .WithMany(p => p.BrandingItemOrganizations)
                    .HasForeignKey(d => d.BrandingItemId)
                    .HasConstraintName("fk_rails_cc826c4f19");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.BrandingItemOrganizations)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("fk_rails_6c00518c93");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Name, "index_categories_on_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.BgColor)
                    .HasMaxLength(255)
                    .HasColumnName("bg_color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DefaultThumbnailUrl)
                    .HasMaxLength(255)
                    .HasColumnName("default_thumbnail_url");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.FgColor)
                    .HasMaxLength(255)
                    .HasColumnName("fg_color");

                entity.Property(e => e.Focus)
                    .HasMaxLength(255)
                    .HasColumnName("focus");

                entity.Property(e => e.IsContentMastery)
                    .HasColumnName("is_content_mastery")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Label)
                    .HasMaxLength(255)
                    .HasColumnName("label");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PracticeTime)
                    .HasMaxLength(255)
                    .HasColumnName("practice_time");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.ToTable("certificates");

                entity.HasIndex(e => e.EnrollmentId, "index_certificates_on_enrollment_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DownloadUrl)
                    .HasMaxLength(255)
                    .HasColumnName("download_url");

                entity.Property(e => e.EnrollmentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enrollment_id");

                entity.Property(e => e.ErrorReason)
                    .HasColumnType("text")
                    .HasColumnName("error_reason");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_at");

                entity.Property(e => e.Grade)
                    .HasPrecision(6, 4)
                    .HasColumnName("grade");

                entity.Property(e => e.LastGeneratedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_generated_at");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VerifyUuid)
                    .HasMaxLength(255)
                    .HasColumnName("verify_uuid");

                entity.HasOne(d => d.Enrollment)
                    .WithMany(p => p.Certificates)
                    .HasForeignKey(d => d.EnrollmentId)
                    .HasConstraintName("fk_rails_e6522b212a");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.ToTable("chapters");

                entity.HasIndex(e => new { e.Code, e.CourseVersionId }, "chapter_code_course_version_unique_index")
                    .IsUnique();

                entity.HasIndex(e => e.CourseVersionId, "index_chapters_on_course_version_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CourseVersionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_version_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsGraded).HasColumnName("is_graded");

                entity.Property(e => e.LongDescription)
                    .HasColumnType("text")
                    .HasColumnName("long_description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ReleasedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("released_at");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Weight)
                    .HasColumnType("int(11)")
                    .HasColumnName("weight");

                entity.HasOne(d => d.CourseVersion)
                    .WithMany(p => p.Chapters)
                    .HasForeignKey(d => d.CourseVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b1161b6d73");
            });

            modelBuilder.Entity<CoachTip>(entity =>
            {
                entity.ToTable("coach_tips");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.OembedResourceId, "index_coach_tips_on_oembed_resource_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OembedResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("oembed_resource_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.OembedResource)
                    .WithMany(p => p.CoachTips)
                    .HasForeignKey(d => d.OembedResourceId)
                    .HasConstraintName("fk_rails_ebbc034e47");
            });

            modelBuilder.Entity<CommonInformationList>(entity =>
            {
                entity.ToTable("common_information_lists");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.ResourceType, e.ResourceId }, "index_common_information_lists_on_resource_type_and_resource_id");

                entity.HasIndex(e => e.CommonInformationListDefinitionId, "information_list_definition_on_list_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CommonInformationListDefinitionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("common_information_list_definition_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_id");

                entity.Property(e => e.ResourceType).HasColumnName("resource_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.CommonInformationListDefinition)
                    .WithMany(p => p.CommonInformationLists)
                    .HasForeignKey(d => d.CommonInformationListDefinitionId)
                    .HasConstraintName("fk_rails_d7b54d3cc4");
            });

            modelBuilder.Entity<CommonInformationListDefinition>(entity =>
            {
                entity.ToTable("common_information_list_definitions");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ListStyle)
                    .HasMaxLength(255)
                    .HasColumnName("list_style");

                entity.Property(e => e.ListStyleImagePath)
                    .HasMaxLength(255)
                    .HasColumnName("list_style_image_path");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CommonInformationListItem>(entity =>
            {
                entity.ToTable("common_information_list_items");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CommonInformationListId, "common_information_list_on_items_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CommonInformationListId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("common_information_list_id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.CommonInformationList)
                    .WithMany(p => p.CommonInformationListItems)
                    .HasForeignKey(d => d.CommonInformationListId)
                    .HasConstraintName("fk_rails_370c0442ba");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.HasIndex(e => e.Slug, "courses_slug_unique_constraint_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CertificateAvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_available_at");

                entity.Property(e => e.CertificateName)
                    .HasMaxLength(255)
                    .HasColumnName("certificate_name");

                entity.Property(e => e.CoursePrereqSlug)
                    .HasMaxLength(255)
                    .HasColumnName("course_prereq_slug");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DurationDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration_days");

                entity.Property(e => e.IsAdvertised).HasColumnName("is_advertised");

                entity.Property(e => e.IsCertified).HasColumnName("is_certified");

                entity.Property(e => e.IsVisibleToStudents).HasColumnName("is_visible_to_students");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(255)
                    .HasColumnName("level_name");

                entity.Property(e => e.LowestPassingGrade)
                    .HasPrecision(5, 4)
                    .HasColumnName("lowest_passing_grade");

                entity.Property(e => e.MaxStudentsEnrollmentAllowed)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_students_enrollment_allowed");

                entity.Property(e => e.Slug).HasColumnName("slug");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CourseInstructor>(entity =>
            {
                entity.ToTable("course_instructors");

                entity.HasIndex(e => e.CourseId, "index_course_instructors_on_course_id");

                entity.HasIndex(e => e.InstructorId, "index_course_instructors_on_instructor_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CourseId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.InstructorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("instructor_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("fk_rails_146bab2632");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.CourseInstructors)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("fk_rails_a6ee52c5df");
            });

            modelBuilder.Entity<CourseRun>(entity =>
            {
                entity.ToTable("course_runs");

                entity.HasIndex(e => e.CourseVersionId, "index_course_runs_on_course_version_id");

                entity.HasIndex(e => e.OrganizationId, "index_course_runs_on_organization_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CourseVersionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_version_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.EndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("ends_at");

                entity.Property(e => e.EnrollmentEndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("enrollment_ends_at");

                entity.Property(e => e.EnrollmentStartsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("enrollment_starts_at");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_id");

                entity.Property(e => e.StartsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("starts_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.CourseVersion)
                    .WithMany(p => p.CourseRuns)
                    .HasForeignKey(d => d.CourseVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_ad507fd52f");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.CourseRuns)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("fk_rails_5795b8ef81");
            });

            modelBuilder.Entity<CourseVersion>(entity =>
            {
                entity.ToTable("course_versions");

                entity.HasIndex(e => new { e.Code, e.CourseId }, "course_version_code_course_unique_index")
                    .IsUnique();

                entity.HasIndex(e => new { e.VersionNumber, e.CourseId }, "course_version_number_unique")
                    .IsUnique();

                entity.HasIndex(e => e.CourseId, "index_course_versions_on_course_id");

                entity.HasIndex(e => e.OembedResourceId, "index_course_versions_on_oembed_resource_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AnnouncementAt)
                    .HasColumnType("datetime")
                    .HasColumnName("announcement_at");

                entity.Property(e => e.CertificateAvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_available_at");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CourseAuthors)
                    .HasColumnType("text")
                    .HasColumnName("course_authors");

                entity.Property(e => e.CourseId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_id");

                entity.Property(e => e.CourseInfo)
                    .HasColumnType("text")
                    .HasColumnName("course_info");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.LongDescription)
                    .HasColumnType("text")
                    .HasColumnName("long_description");

                entity.Property(e => e.OembedResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("oembed_resource_id");

                entity.Property(e => e.ShortDescription)
                    .HasColumnType("text")
                    .HasColumnName("short_description");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VersionNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("version_number");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseVersions)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_5bd99403a0");

                entity.HasOne(d => d.OembedResource)
                    .WithMany(p => p.CourseVersions)
                    .HasForeignKey(d => d.OembedResourceId)
                    .HasConstraintName("fk_rails_df41bca0ca");
            });

            modelBuilder.Entity<CourseVideo>(entity =>
            {
                entity.ToTable("course_videos");

                entity.HasIndex(e => e.OembedResourceId, "index_course_videos_on_oembed_resource_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Authors)
                    .HasMaxLength(255)
                    .HasColumnName("authors");

                entity.Property(e => e.Captions)
                    .HasColumnType("text")
                    .HasColumnName("captions");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.OembedResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("oembed_resource_id");

                entity.Property(e => e.ShowsCaptions).HasColumnName("shows_captions");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UploadAt).HasColumnName("upload_at");

                entity.Property(e => e.UrlName)
                    .HasMaxLength(255)
                    .HasColumnName("url_name");

                entity.HasOne(d => d.OembedResource)
                    .WithMany(p => p.CourseVideos)
                    .HasForeignKey(d => d.OembedResourceId)
                    .HasConstraintName("fk_rails_f2b0761c0d");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.ToTable("enrollments");

                entity.HasIndex(e => e.CourseRunId, "index_enrollments_on_course_run_id");

                entity.HasIndex(e => e.UserId, "index_enrollments_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CourseRunId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_run_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DroppedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("dropped_at");

                entity.Property(e => e.EndedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("ended_at");

                entity.Property(e => e.EnrollmentType)
                    .HasMaxLength(255)
                    .HasColumnName("enrollment_type");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.SeedNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("seed_number");

                entity.Property(e => e.StartedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("started_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.CourseRun)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.CourseRunId)
                    .HasConstraintName("fk_rails_774646d52e");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_e860e0e46b");
            });

            modelBuilder.Entity<HtmlComponent>(entity =>
            {
                entity.ToTable("html_components");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Import>(entity =>
            {
                entity.ToTable("imports");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.ImportType)
                    .HasMaxLength(255)
                    .HasColumnName("import_type")
                    .HasDefaultValueSql("'console'");

                entity.Property(e => e.ImportedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("imported_at");

                entity.Property(e => e.ImportedUsersCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("imported_users_count");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserImportFailsCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_import_fails_count");
            });

            modelBuilder.Entity<ImportedUser>(entity =>
            {
                entity.ToTable("imported_users");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ImportId, "index_imported_users_on_import_id");

                entity.HasIndex(e => e.OrganizationId, "index_imported_users_on_organization_id");

                entity.HasIndex(e => e.UserId, "index_imported_users_on_user_id");

                entity.HasIndex(e => new { e.MemberCode, e.OrganizationId }, "unique_member_code_organization")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AtavusGuid)
                    .HasMaxLength(255)
                    .HasColumnName("atavus_guid");

                entity.Property(e => e.Certified).HasColumnName("certified");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.ImportAction)
                    .HasMaxLength(255)
                    .HasColumnName("import_action");

                entity.Property(e => e.ImportFields)
                    .HasColumnType("json")
                    .HasColumnName("import_fields");

                entity.Property(e => e.ImportId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("import_id");

                entity.Property(e => e.InitialMiddleName)
                    .HasMaxLength(255)
                    .HasColumnName("initial_middle_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.MemberCode).HasColumnName("member_code");

                entity.Property(e => e.Metadata)
                    .HasColumnType("json")
                    .HasColumnName("metadata");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(255)
                    .HasColumnName("program_name");

                entity.Property(e => e.RegisteredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("registered_at");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .HasColumnName("street");

                entity.Property(e => e.Street2)
                    .HasMaxLength(255)
                    .HasColumnName("street_2");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.Property(e => e.Zip)
                    .HasMaxLength(255)
                    .HasColumnName("zip");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.ImportedUsers)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("fk_rails_732085b592");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ImportedUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_4cc66325ee");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("instructors");

                entity.HasIndex(e => e.Code, "instructors_code_unique_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Learn>(entity =>
            {
                entity.ToTable("learns");

                entity.HasIndex(e => e.Code, "index_learns_on_code")
                    .IsUnique();

                entity.HasIndex(e => e.CourseId, "index_learns_on_course_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CourseId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Learns)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("fk_rails_852fb87886");
            });

            modelBuilder.Entity<LearnCourseVideo>(entity =>
            {
                entity.ToTable("learn_course_videos");

                entity.HasIndex(e => new { e.CourseVideoId, e.LearnId }, "course_video_learn_unique")
                    .IsUnique();

                entity.HasIndex(e => e.CourseVideoId, "index_learn_course_videos_on_course_video_id");

                entity.HasIndex(e => e.LearnId, "index_learn_course_videos_on_learn_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CourseVideoId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_video_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsFreeToPlay).HasColumnName("is_free_to_play");

                entity.Property(e => e.LearnId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("learn_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.CourseVideo)
                    .WithMany(p => p.LearnCourseVideos)
                    .HasForeignKey(d => d.CourseVideoId)
                    .HasConstraintName("fk_rails_9e8841012e");

                entity.HasOne(d => d.Learn)
                    .WithMany(p => p.LearnCourseVideos)
                    .HasForeignKey(d => d.LearnId)
                    .HasConstraintName("fk_rails_513703810a");
            });

            modelBuilder.Entity<OembedProvider>(entity =>
            {
                entity.ToTable("oembed_providers");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DefaultOptions)
                    .HasColumnType("json")
                    .HasColumnName("default_options");

                entity.Property(e => e.Format)
                    .HasMaxLength(255)
                    .HasColumnName("format");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UrlEndpoint)
                    .HasMaxLength(255)
                    .HasColumnName("url_endpoint");
            });

            modelBuilder.Entity<OembedResource>(entity =>
            {
                entity.ToTable("oembed_resources");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.OembedProviderId, "index_oembed_resources_on_oembed_provider_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LastResponse)
                    .HasColumnType("json")
                    .HasColumnName("last_response");

                entity.Property(e => e.LastResponseAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_response_at");

                entity.Property(e => e.OembedProviderId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("oembed_provider_id");

                entity.Property(e => e.Options)
                    .HasColumnType("json")
                    .HasColumnName("options");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");

                entity.HasOne(d => d.OembedProvider)
                    .WithMany(p => p.OembedResources)
                    .HasForeignKey(d => d.OembedProviderId)
                    .HasConstraintName("fk_rails_b6a7eb0ad3");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("organizations");

                entity.HasIndex(e => e.AtavusGuid, "index_organizations_on_atavus_guid")
                    .IsUnique();

                entity.HasIndex(e => e.Code, "index_organizations_on_code")
                    .IsUnique();

                entity.HasIndex(e => e.ImportId, "index_organizations_on_import_id");

                entity.HasIndex(e => e.Name, "index_organizations_on_name")
                    .IsUnique();

                entity.HasIndex(e => e.OrganizationPlanId, "index_organizations_on_organization_plan_id");

                entity.HasIndex(e => e.PlanId, "index_organizations_on_plan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AtavusGuid).HasColumnName("atavus_guid");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Domain)
                    .HasMaxLength(255)
                    .HasColumnName("domain");

                entity.Property(e => e.ImportId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("import_id");

                entity.Property(e => e.LicenseEndsAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("license_ends_at");

                entity.Property(e => e.LicenseStartsAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("license_starts_at");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OrganizationPlanId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_plan_id");

                entity.Property(e => e.PersonalizedLogo)
                    .HasColumnType("text")
                    .HasColumnName("personalized_logo");

                entity.Property(e => e.PlanId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.PortalGoesLivesAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("portal_goes_lives_at");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Subdomain)
                    .HasMaxLength(255)
                    .HasColumnName("subdomain");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(255)
                    .HasColumnName("time_zone")
                    .HasDefaultValueSql("'UTC'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("fk_rails_ff73f06eb7");

                entity.HasOne(d => d.OrganizationPlan)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.OrganizationPlanId)
                    .HasConstraintName("fk_rails_0f9709eae3");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("fk_rails_7d8d2861ef");
            });

            modelBuilder.Entity<OrganizationCoursePolicy>(entity =>
            {
                entity.ToTable("organization_course_policies");

                entity.HasIndex(e => e.CourseId, "index_organization_course_policies_on_course_id");

                entity.HasIndex(e => e.OrganizationId, "index_organization_course_policies_on_organization_id");

                entity.HasIndex(e => new { e.CourseId, e.OrganizationId }, "organization_course_policy_unique_course")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CertificationCompletionLimitAt)
                    .HasColumnType("datetime")
                    .HasColumnName("certification_completion_limit_at");

                entity.Property(e => e.CourseEndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("course_ends_at");

                entity.Property(e => e.CourseId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DiscountEndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("discount_ends_at");

                entity.Property(e => e.DiscountPrecent)
                    .HasPrecision(10)
                    .HasColumnName("discount_precent");

                entity.Property(e => e.DurationDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration_days");

                entity.Property(e => e.EnrollmentEndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("enrollment_ends_at");

                entity.Property(e => e.EnrollmentStartsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("enrollment_starts_at");

                entity.Property(e => e.LowestPassingGrade)
                    .HasPrecision(5, 2)
                    .HasColumnName("lowest_passing_grade");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_id");

                entity.Property(e => e.RecertificationFrequencyDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("recertification_frequency_days");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.OrganizationCoursePolicies)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_5cedde8c53");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationCoursePolicies)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_a4de4dd3dc");
            });

            modelBuilder.Entity<OrganizationPlan>(entity =>
            {
                entity.ToTable("organization_plans");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<OrganizationPlanCategory>(entity =>
            {
                entity.ToTable("organization_plan_categories");

                entity.HasIndex(e => e.CategoryId, "index_organization_plan_categories_on_category_id");

                entity.HasIndex(e => e.OrganizationPlanId, "index_organization_plan_categories_on_organization_plan_id");

                entity.HasIndex(e => new { e.OrganizationPlanId, e.CategoryId }, "organization_plan_categories_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("category_id");

                entity.Property(e => e.OrganizationPlanId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_plan_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.OrganizationPlanCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_rails_07d19cd1bb");

                entity.HasOne(d => d.OrganizationPlan)
                    .WithMany(p => p.OrganizationPlanCategories)
                    .HasForeignKey(d => d.OrganizationPlanId)
                    .HasConstraintName("fk_rails_038e76de5c");
            });

            modelBuilder.Entity<OrganizationPlansPlanGuide>(entity =>
            {
                entity.ToTable("organization_plans_plan_guides");

                entity.HasIndex(e => e.OrganizationPlanId, "index_organization_plans_plan_guides_on_organization_plan_id");

                entity.HasIndex(e => e.PlanGuideId, "index_organization_plans_plan_guides_on_plan_guide_id");

                entity.HasIndex(e => new { e.OrganizationPlanId, e.PlanGuideId }, "organization_plan_plan_guides_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.OrganizationPlanId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_plan_id");

                entity.Property(e => e.PlanGuideId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("plan_guide_id");

                entity.HasOne(d => d.OrganizationPlan)
                    .WithMany(p => p.OrganizationPlansPlanGuides)
                    .HasForeignKey(d => d.OrganizationPlanId)
                    .HasConstraintName("fk_rails_f8a8d06b78");

                entity.HasOne(d => d.PlanGuide)
                    .WithMany(p => p.OrganizationPlansPlanGuides)
                    .HasForeignKey(d => d.PlanGuideId)
                    .HasConstraintName("fk_rails_60face4a9f");
            });

            modelBuilder.Entity<OrganizationUser>(entity =>
            {
                entity.ToTable("organization_users");

                entity.HasIndex(e => e.OrganizationId, "index_organization_users_on_organization_id");

                entity.HasIndex(e => e.UserId, "index_organization_users_on_user_id");

                entity.HasIndex(e => new { e.OrganizationId, e.UserId }, "organization_user_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("activated_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_id");

                entity.Property(e => e.RetiredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("retired_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrganizationUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_8d9b20725d");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plans");

                entity.HasIndex(e => e.SortNumber, "index_plans_on_sort_number");

                entity.HasIndex(e => e.StripeId, "index_plans_on_stripe_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Permissions)
                    .HasColumnType("json")
                    .HasColumnName("permissions");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StripeId).HasColumnName("stripe_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("tag")
                    .HasDefaultValueSql("'tier'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PlanBuilder>(entity =>
            {
                entity.ToTable("plan_builders");

                entity.HasIndex(e => e.UserId, "index_plan_builders_on_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AtavusTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("atavus_time");

                entity.Property(e => e.AtavusWork)
                    .HasColumnType("int(11)")
                    .HasColumnName("atavus_work");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.PlanSlug)
                    .HasMaxLength(255)
                    .HasColumnName("plan_slug");

                entity.Property(e => e.PracticesMinutes)
                    .HasColumnType("int(11)")
                    .HasColumnName("practices_minutes");

                entity.Property(e => e.PracticesQuantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("practices_quantity");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.PlanBuilder)
                    .HasForeignKey<PlanBuilder>(d => d.UserId)
                    .HasConstraintName("fk_rails_a4819586ca");
            });

            modelBuilder.Entity<PlanGuide>(entity =>
            {
                entity.ToTable("plan_guides");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.InCoachKit, "index_plan_guides_on_in_coach_kit");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DrillProgressionPhilosophy)
                    .HasColumnType("text")
                    .HasColumnName("drill_progression_philosophy");

                entity.Property(e => e.InCoachKit)
                    .HasColumnName("in_coach_kit")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Overview)
                    .HasColumnType("text")
                    .HasColumnName("overview");

                entity.Property(e => e.Slug)
                    .HasMaxLength(255)
                    .HasColumnName("slug");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PlanPrice>(entity =>
            {
                entity.ToTable("plan_prices");

                entity.HasIndex(e => e.PlanId, "index_plan_prices_on_plan_id");

                entity.HasIndex(e => e.StripeId, "index_plan_prices_on_stripe_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'usd'");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(255)
                    .HasColumnName("nickname");

                entity.Property(e => e.Periodicity)
                    .HasMaxLength(255)
                    .HasColumnName("periodicity")
                    .HasDefaultValueSql("'year'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.Price)
                    .HasPrecision(6, 2)
                    .HasColumnName("price");

                entity.Property(e => e.StripeId).HasColumnName("stripe_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanPrices)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("fk_rails_3e32e08315");
            });

            modelBuilder.Entity<Practice>(entity =>
            {
                entity.ToTable("practices");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PracticeWeekId, "index_practices_on_practice_week_id");

                entity.HasIndex(e => e.Relevance, "index_practices_on_relevance");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.PracticeWeekId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("practice_week_id");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.TimePerDrill)
                    .HasMaxLength(255)
                    .HasColumnName("time_per_drill");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.PracticeWeek)
                    .WithMany(p => p.Practices)
                    .HasForeignKey(d => d.PracticeWeekId)
                    .HasConstraintName("fk_rails_ef29882814");
            });

            modelBuilder.Entity<PracticeDrill>(entity =>
            {
                entity.ToTable("practice_drills");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PracticeDrillCategoryId, "index_practice_drills_on_practice_drill_category_id");

                entity.HasIndex(e => e.PracticeId, "index_practice_drills_on_practice_id");

                entity.HasIndex(e => e.Relevance, "index_practice_drills_on_relevance");

                entity.HasIndex(e => e.VideoId, "index_practice_drills_on_video_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.PracticeDrillCategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("practice_drill_category_id");

                entity.Property(e => e.PracticeId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("practice_id");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideoId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("video_id");

                entity.HasOne(d => d.PracticeDrillCategory)
                    .WithMany(p => p.PracticeDrills)
                    .HasForeignKey(d => d.PracticeDrillCategoryId)
                    .HasConstraintName("fk_rails_dfeae92637");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeDrills)
                    .HasForeignKey(d => d.PracticeId)
                    .HasConstraintName("fk_rails_762f752a4f");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.PracticeDrills)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("fk_rails_4d11f16efb");
            });

            modelBuilder.Entity<PracticeDrillCategory>(entity =>
            {
                entity.ToTable("practice_drill_categories");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PracticeWeek>(entity =>
            {
                entity.ToTable("practice_weeks");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PlanGuideId, "index_practice_weeks_on_plan_guide_id");

                entity.HasIndex(e => e.Relevance, "index_practice_weeks_on_relevance");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PlanGuideId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("plan_guide_id");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.PlanGuide)
                    .WithMany(p => p.PracticeWeeks)
                    .HasForeignKey(d => d.PlanGuideId)
                    .HasConstraintName("fk_rails_857c52fd8e");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.HasIndex(e => new { e.ProductableType, e.ProductableId }, "index_products_on_productable_type_and_productable_id");

                entity.HasIndex(e => e.StripeId, "index_products_on_stripe_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Caption)
                    .HasMaxLength(255)
                    .HasColumnName("caption");

                entity.Property(e => e.Category)
                    .HasMaxLength(255)
                    .HasColumnName("category")
                    .HasDefaultValueSql("'plan'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.InCoachKit)
                    .HasColumnName("in_coach_kit")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Permissions)
                    .HasColumnType("json")
                    .HasColumnName("permissions");

                entity.Property(e => e.ProductableId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("productable_id");

                entity.Property(e => e.ProductableType).HasColumnName("productable_type");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StripeId).HasColumnName("stripe_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductSku>(entity =>
            {
                entity.ToTable("product_skus");

                entity.HasIndex(e => e.ProductId, "index_product_skus_on_product_id");

                entity.HasIndex(e => e.StripeId, "index_product_skus_on_stripe_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'usd'");

                entity.Property(e => e.Price)
                    .HasPrecision(6, 2)
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("product_id");

                entity.Property(e => e.StripeId).HasColumnName("stripe_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("tag")
                    .HasDefaultValueSql("'general'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSkus)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_rails_ecb75602ee");
            });

            modelBuilder.Entity<ProductUser>(entity =>
            {
                entity.ToTable("product_users");

                entity.HasIndex(e => e.ProductId, "index_product_users_on_product_id");

                entity.HasIndex(e => e.Status, "index_product_users_on_status");

                entity.HasIndex(e => e.UserId, "index_product_users_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ProductId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("product_id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.StripeId)
                    .HasMaxLength(255)
                    .HasColumnName("stripe_id");

                entity.Property(e => e.StripeProductSku)
                    .HasMaxLength(255)
                    .HasColumnName("stripe_product_sku");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("questions");

                entity.HasIndex(e => e.ChapterId, "index_questions_on_chapter_id");

                entity.HasIndex(e => e.QuizId, "index_questions_on_quiz_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ChapterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chapter_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Media)
                    .HasColumnType("json")
                    .HasColumnName("media");

                entity.Property(e => e.QuestionType)
                    .HasMaxLength(255)
                    .HasColumnName("question_type");

                entity.Property(e => e.QuizId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("quiz_id");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("fk_rails_0238c45a86");
            });

            modelBuilder.Entity<QuestionChoice>(entity =>
            {
                entity.ToTable("question_choices");

                entity.HasIndex(e => e.QuestionId, "index_question_choices_on_question_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsCorrect).HasColumnName("is_correct");

                entity.Property(e => e.QuestionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("question_id");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionChoices)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("fk_rails_e0c1562c5c");
            });

            modelBuilder.Entity<QuestionVersion>(entity =>
            {
                entity.ToTable("question_versions");

                entity.HasIndex(e => e.QuestionId, "index_question_versions_on_question_id");

                entity.HasIndex(e => e.QuizVersionId, "index_question_versions_on_quiz_version_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.QuestionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("question_id");

                entity.Property(e => e.QuizVersionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("quiz_version_id");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionVersions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("fk_rails_cf7c38aa42");

                entity.HasOne(d => d.QuizVersion)
                    .WithMany(p => p.QuestionVersions)
                    .HasForeignKey(d => d.QuizVersionId)
                    .HasConstraintName("fk_rails_68b235f0b3");
            });

            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.ToTable("quizzes");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.Heading)
                    .HasMaxLength(255)
                    .HasColumnName("heading");

                entity.Property(e => e.MaxSubmissions)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_submissions");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<QuizSubmission>(entity =>
            {
                entity.ToTable("quiz_submissions");

                entity.HasIndex(e => e.EnrollmentId, "index_quiz_submissions_on_enrollment_id");

                entity.HasIndex(e => e.QuizId, "index_quiz_submissions_on_quiz_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CalculatedGrade)
                    .HasPrecision(5, 4)
                    .HasColumnName("calculated_grade");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.EnrollmentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enrollment_id");

                entity.Property(e => e.QuizId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("quiz_id");

                entity.Property(e => e.SubmittedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("submitted_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Enrollment)
                    .WithMany(p => p.QuizSubmissions)
                    .HasForeignKey(d => d.EnrollmentId)
                    .HasConstraintName("fk_rails_4c75416398");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuizSubmissions)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("fk_rails_473863d022");
            });

            modelBuilder.Entity<QuizVersion>(entity =>
            {
                entity.ToTable("quiz_versions");

                entity.HasIndex(e => e.QuizId, "index_quiz_versions_on_quiz_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.QuizId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("quiz_id");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(255)
                    .HasColumnName("version_code");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuizVersions)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("fk_rails_7777bc9d80");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<SchemaMigration>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("schema_migrations");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<SeedMigrationDataMigration>(entity =>
            {
                entity.ToTable("seed_migration_data_migrations");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.MigratedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("migrated_on");

                entity.Property(e => e.Runtime)
                    .HasColumnType("int(11)")
                    .HasColumnName("runtime");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("sessions");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.SessionId, "index_sessions_on_session_id")
                    .IsUnique();

                entity.HasIndex(e => e.UpdatedAt, "index_sessions_on_updated_at");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<StripeEvent>(entity =>
            {
                entity.ToTable("stripe_events");

                entity.HasIndex(e => e.Event, "index_stripe_events_on_event");

                entity.HasIndex(e => e.StripeId, "index_stripe_events_on_stripe_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ApiVersion)
                    .HasMaxLength(255)
                    .HasColumnName("api_version");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("json")
                    .HasColumnName("data");

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Request)
                    .HasColumnType("json")
                    .HasColumnName("request");

                entity.Property(e => e.StripeId).HasColumnName("stripe_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<StudentUnitProgress>(entity =>
            {
                entity.ToTable("student_unit_progresses");

                entity.HasIndex(e => e.EnrollmentId, "index_student_unit_progresses_on_enrollment_id");

                entity.HasIndex(e => e.UnitId, "index_student_unit_progresses_on_unit_id");

                entity.HasIndex(e => new { e.EnrollmentId, e.UnitId }, "student_unit_progress_enrollment_unit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("completed_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.EnrollmentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enrollment_id");

                entity.Property(e => e.LastCalculatedGrade)
                    .HasPrecision(5, 4)
                    .HasColumnName("last_calculated_grade");

                entity.Property(e => e.LastEventAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_event_at");

                entity.Property(e => e.MaxCalculatedGrade)
                    .HasPrecision(5, 4)
                    .HasColumnName("max_calculated_grade");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.UnitId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unit_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Enrollment)
                    .WithMany(p => p.StudentUnitProgresses)
                    .HasForeignKey(d => d.EnrollmentId)
                    .HasConstraintName("fk_rails_be8107869a");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.StudentUnitProgresses)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_rails_b34836cb1c");
            });

            modelBuilder.Entity<StudentUnitProgressHistory>(entity =>
            {
                entity.ToTable("student_unit_progress_histories");

                entity.HasIndex(e => e.StudentUnitProgressId, "index_student_progress_history_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Attempts)
                    .HasColumnType("int(11)")
                    .HasColumnName("attempts");

                entity.Property(e => e.CalculatedGrade)
                    .HasPrecision(5, 4)
                    .HasColumnName("calculated_grade");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.EventAt)
                    .HasColumnType("datetime")
                    .HasColumnName("event_at");

                entity.Property(e => e.EventData)
                    .HasColumnType("json")
                    .HasColumnName("event_data");

                entity.Property(e => e.Seed)
                    .HasColumnType("int(11)")
                    .HasColumnName("seed");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.StudentUnitProgressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("student_unit_progress_id");

                entity.Property(e => e.Timezone)
                    .HasMaxLength(255)
                    .HasColumnName("timezone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.StudentUnitProgress)
                    .WithMany(p => p.StudentUnitProgressHistories)
                    .HasForeignKey(d => d.StudentUnitProgressId)
                    .HasConstraintName("fk_rails_f95a7477b8");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("subscriptions");

                entity.HasIndex(e => e.PlanId, "index_subscriptions_on_plan_id");

                entity.HasIndex(e => e.StripeId, "index_subscriptions_on_stripe_id")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "index_subscriptions_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CancelAt)
                    .HasColumnType("datetime")
                    .HasColumnName("cancel_at");

                entity.Property(e => e.CancelAtPeriodEnd)
                    .HasColumnName("cancel_at_period_end")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LastBillingAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_billing_at");

                entity.Property(e => e.PendingAction)
                    .HasColumnType("json")
                    .HasColumnName("pending_action");

                entity.Property(e => e.PlanId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("plan_id");

                entity.Property(e => e.RenovationAt)
                    .HasColumnType("datetime")
                    .HasColumnName("renovation_at");

                entity.Property(e => e.StartAt)
                    .HasColumnType("datetime")
                    .HasColumnName("start_at");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.StripeId).HasColumnName("stripe_id");

                entity.Property(e => e.StripePlanId)
                    .HasMaxLength(255)
                    .HasColumnName("stripe_plan_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("fk_rails_63d3df128b");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_933bdff476");
            });

            modelBuilder.Entity<SubscriptionLog>(entity =>
            {
                entity.ToTable("subscription_logs");

                entity.HasIndex(e => e.Action, "index_subscription_logs_on_action");

                entity.HasIndex(e => e.SubscriptionId, "index_subscription_logs_on_subscription_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Metadata)
                    .HasColumnType("text")
                    .HasColumnName("metadata");

                entity.Property(e => e.SubscriptionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("subscription_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionLogs)
                    .HasForeignKey(d => d.SubscriptionId)
                    .HasConstraintName("fk_rails_19ff0b91bb");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("units");

                entity.HasIndex(e => e.ChapterId, "index_units_on_chapter_id");

                entity.HasIndex(e => new { e.Code, e.ChapterId }, "unit_code_chapter_unique_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ChapterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chapter_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.ComponentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("component_id");

                entity.Property(e => e.ComponentType)
                    .HasMaxLength(255)
                    .HasColumnName("component_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.MinutesEstimate)
                    .HasColumnType("int(11)")
                    .HasColumnName("minutes_estimate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.SortNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Chapter)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.ChapterId)
                    .HasConstraintName("fk_rails_fd04c358f4");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Active, "index_users_on_active");

                entity.HasIndex(e => e.AtavusGuid, "index_users_on_atavus_guid")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "index_users_on_email")
                    .IsUnique();

                entity.HasIndex(e => e.OrganizationId, "index_users_on_organization_id");

                entity.HasIndex(e => e.ResetPasswordToken, "index_users_on_reset_password_token")
                    .IsUnique();

                entity.HasIndex(e => e.RoleId, "index_users_on_role_id");

                entity.HasIndex(e => e.StripeCustomerId, "index_users_on_stripe_customer_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.MemberCode, e.OrganizationId }, "unique_member_code_organization_users")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("activated_at");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AtavusGuid).HasColumnName("atavus_guid");

                entity.Property(e => e.Certified).HasColumnName("certified");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CurrentSignInAt)
                    .HasColumnType("datetime")
                    .HasColumnName("current_sign_in_at");

                entity.Property(e => e.CurrentSignInIp)
                    .HasMaxLength(255)
                    .HasColumnName("current_sign_in_ip");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EncryptedPassword)
                    .HasMaxLength(255)
                    .HasColumnName("encrypted_password")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.HubspotId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hubspot_id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.LastSignInAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_sign_in_at");

                entity.Property(e => e.LastSignInIp)
                    .HasMaxLength(255)
                    .HasColumnName("last_sign_in_ip");

                entity.Property(e => e.MemberCode).HasColumnName("member_code");

                entity.Property(e => e.Metadata)
                    .HasColumnType("text")
                    .HasColumnName("metadata");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("organization_id");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(255)
                    .HasColumnName("organization_name");

                entity.Property(e => e.Permissions)
                    .HasColumnType("json")
                    .HasColumnName("permissions");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(255)
                    .HasColumnName("program_name");

                entity.Property(e => e.RememberCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("remember_created_at");

                entity.Property(e => e.ResetPasswordSentAt)
                    .HasColumnType("datetime")
                    .HasColumnName("reset_password_sent_at");

                entity.Property(e => e.ResetPasswordToken).HasColumnName("reset_password_token");

                entity.Property(e => e.RoleId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("role_id");

                entity.Property(e => e.SignInCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("sign_in_count");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .HasColumnName("street");

                entity.Property(e => e.Street2)
                    .HasMaxLength(255)
                    .HasColumnName("street_2");

                entity.Property(e => e.StripeCustomerId).HasColumnName("stripe_customer_id");

                entity.Property(e => e.TestAccount)
                    .HasColumnName("test_account")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Zip)
                    .HasMaxLength(255)
                    .HasColumnName("zip");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("fk_rails_642f17018b");
            });

            modelBuilder.Entity<UserCoupon>(entity =>
            {
                entity.ToTable("user_coupons");

                entity.HasIndex(e => new { e.CouponableType, e.CouponableId }, "index_user_coupons_on_couponable_type_and_couponable_id");

                entity.HasIndex(e => e.UserId, "index_user_coupons_on_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CouponableId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("couponable_id");

                entity.Property(e => e.CouponableType).HasColumnName("couponable_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.StripeCode)
                    .HasMaxLength(255)
                    .HasColumnName("stripe_code");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserImportFail>(entity =>
            {
                entity.ToTable("user_import_fails");

                entity.HasIndex(e => e.ImportId, "index_user_import_fails_on_import_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CertificationScore)
                    .HasPrecision(5, 2)
                    .HasColumnName("certification_score");

                entity.Property(e => e.CertificationStatus)
                    .HasMaxLength(255)
                    .HasColumnName("certification_status");

                entity.Property(e => e.Certified).HasColumnName("certified");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FailReason)
                    .HasMaxLength(255)
                    .HasColumnName("fail_reason");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.ImportId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("import_id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.MemberCode)
                    .HasMaxLength(255)
                    .HasColumnName("member_code");

                entity.Property(e => e.Metadata)
                    .HasColumnType("text")
                    .HasColumnName("metadata");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(255)
                    .HasColumnName("organization_code");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.UserImportFails)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("fk_rails_0f116e81bc");
            });

            modelBuilder.Entity<AtavusUserMatcher.Models.Version>(entity =>
            {
                entity.ToTable("versions");

                entity.UseCollation("utf8mb4_general_ci");

                entity.HasIndex(e => new { e.ItemType, e.ItemId }, "index_versions_on_item_type_and_item_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .HasMaxLength(255)
                    .HasColumnName("event");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(191)
                    .HasColumnName("item_type");

                entity.Property(e => e.Object).HasColumnName("object");

                entity.Property(e => e.ObjectChanges).HasColumnName("object_changes");

                entity.Property(e => e.Whodunnit)
                    .HasMaxLength(255)
                    .HasColumnName("whodunnit");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("videos");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CategoryId, "index_videos_on_category_id");

                entity.HasIndex(e => e.CoachTipId, "index_videos_on_coach_tip_id");

                entity.HasIndex(e => e.Name, "index_videos_on_name");

                entity.HasIndex(e => e.OembedResourceId, "index_videos_on_oembed_resource_id");

                entity.HasIndex(e => e.Relevance, "index_videos_on_relevance");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CoachTipId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("coach_tip_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OembedResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("oembed_resource_id");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(255)
                    .HasColumnName("purpose");

                entity.Property(e => e.Relevance)
                    .HasColumnType("int(11)")
                    .HasColumnName("relevance");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_rails_edd73071b6");

                entity.HasOne(d => d.CoachTip)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.CoachTipId)
                    .HasConstraintName("fk_rails_3336d8343a");

                entity.HasOne(d => d.OembedResource)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.OembedResourceId)
                    .HasConstraintName("fk_rails_4393ec6dd5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
