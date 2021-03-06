﻿
using Domain.Validation.Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands.Project
{
    public class UpdateProjectCommand : ProjectCommand
    {
        public UpdateProjectCommand(int id, string name, string description, bool isPrivate)
        {
            Id = id;
            Name = name;
            Description = description;
            IsPrivate = isPrivate;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateProjectCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
