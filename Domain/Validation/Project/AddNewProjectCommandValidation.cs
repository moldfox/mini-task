﻿using Domain.Commands.Project;
using Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validation.Project
{
    public class AddNewProjectCommandValidation : ProjectValidationCommand<AddNewProjectCommand>
    {
       
        
       public AddNewProjectCommandValidation()
        {
            ValidateName();
            ValidateDescription();
            ValidateNameExist();
        }

        
    }
}
