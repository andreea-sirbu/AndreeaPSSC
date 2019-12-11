﻿using PSSC.Models.CommonComponents;
using PSSC.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSSC.Models.FarmacistComponents
{
    public class Email
    {
        private Text emailText;

        public Email(Text email)
        {

            emailText = email;
        }
        public Text getEmail { get { return emailText; } }
        public void checkIfThrow()
        {
            if (!this.emailText.getString.Contains('@') || !this.emailText.getString.Contains('.') || this.emailText.getString.LastIndexOf(".") < this.emailText.getString.LastIndexOf('@'))
            {
                throw new InvalidEmailException();
            }
        }
    }

}