﻿// <auto-generated />
using System;
using LMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LMS.Data.Migrations
{
    [DbContext(typeof(SmartLMSDbContext))]
    [Migration("20180716045551_Initial-migration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LMS.Data.Models.attempts", b =>
                {
                    b.Property<int>("attemptId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("noAttempts");

                    b.Property<int>("score");

                    b.Property<string>("time");

                    b.HasKey("attemptId");

                    b.ToTable("attempts");
                });

            modelBuilder.Entity("LMS.Data.Models.categories", b =>
                {
                    b.Property<Guid>("category_id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("title");

                    b.Property<string>("type");

                    b.HasKey("category_id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("LMS.Data.Models.choices", b =>
                {
                    b.Property<int>("choiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("choice");

                    b.Property<bool>("isCorrect");

                    b.Property<int?>("questionId");

                    b.Property<string>("type");

                    b.HasKey("choiceId");

                    b.HasIndex("questionId");

                    b.ToTable("choices");
                });

            modelBuilder.Entity("LMS.Data.Models.courses", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("author");

                    b.Property<Guid?>("categoriescategory_id");

                    b.Property<DateTime>("createdDate");

                    b.Property<string>("description");

                    b.Property<string>("image");

                    b.Property<bool>("status");

                    b.Property<string>("title");

                    b.Property<string>("type");

                    b.HasKey("courseId");

                    b.HasIndex("categoriescategory_id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("LMS.Data.Models.questions", b =>
                {
                    b.Property<int>("questionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("question");

                    b.Property<bool>("status");

                    b.Property<bool>("type");

                    b.Property<int?>("unitId");

                    b.HasKey("questionId");

                    b.HasIndex("unitId");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("LMS.Data.Models.responses", b =>
                {
                    b.Property<int>("responseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("attemptId");

                    b.Property<int?>("choiceId");

                    b.Property<bool>("isCorrect");

                    b.Property<int?>("questionId");

                    b.Property<string>("response");

                    b.Property<Guid?>("userId");

                    b.HasKey("responseId");

                    b.HasIndex("attemptId");

                    b.HasIndex("choiceId");

                    b.HasIndex("questionId");

                    b.HasIndex("userId");

                    b.ToTable("responses");
                });

            modelBuilder.Entity("LMS.Data.Models.units", b =>
                {
                    b.Property<int>("unitId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("compStatus");

                    b.Property<int?>("courseId");

                    b.Property<DateTime>("createdDate");

                    b.Property<string>("description");

                    b.Property<string>("score");

                    b.Property<bool>("status");

                    b.Property<int>("timeSpent");

                    b.Property<string>("title");

                    b.Property<string>("type");

                    b.HasKey("unitId");

                    b.HasIndex("courseId");

                    b.ToTable("units");
                });

            modelBuilder.Entity("LMS.Data.Models.users", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("createdDate");

                    b.Property<string>("password");

                    b.Property<bool>("status");

                    b.Property<string>("useremail");

                    b.Property<string>("username");

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("LMS.Data.Models.choices", b =>
                {
                    b.HasOne("LMS.Data.Models.questions", "question")
                        .WithMany("choice")
                        .HasForeignKey("questionId");
                });

            modelBuilder.Entity("LMS.Data.Models.courses", b =>
                {
                    b.HasOne("LMS.Data.Models.categories")
                        .WithMany("course")
                        .HasForeignKey("categoriescategory_id");
                });

            modelBuilder.Entity("LMS.Data.Models.questions", b =>
                {
                    b.HasOne("LMS.Data.Models.units", "unit")
                        .WithMany("question")
                        .HasForeignKey("unitId");
                });

            modelBuilder.Entity("LMS.Data.Models.responses", b =>
                {
                    b.HasOne("LMS.Data.Models.attempts", "attempt")
                        .WithMany()
                        .HasForeignKey("attemptId");

                    b.HasOne("LMS.Data.Models.choices", "choice")
                        .WithMany()
                        .HasForeignKey("choiceId");

                    b.HasOne("LMS.Data.Models.questions", "question")
                        .WithMany()
                        .HasForeignKey("questionId");

                    b.HasOne("LMS.Data.Models.users", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("LMS.Data.Models.units", b =>
                {
                    b.HasOne("LMS.Data.Models.courses", "course")
                        .WithMany("units")
                        .HasForeignKey("courseId");
                });
#pragma warning restore 612, 618
        }
    }
}
