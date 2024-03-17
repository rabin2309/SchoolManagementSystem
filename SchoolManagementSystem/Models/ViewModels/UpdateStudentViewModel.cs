﻿namespace SchoolManagementSystem.Models.ViewModels
{
    public class UpdateStudentViewModel
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Picture { get; set; }
        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
