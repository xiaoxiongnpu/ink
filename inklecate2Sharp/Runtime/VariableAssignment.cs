﻿using System;

namespace Inklewriter.Runtime
{
    // The value to be assigned is popped off the evaluation stack, so no need to keep it here
    public class VariableAssignment : Runtime.Object
    {
        public string variableName { get; protected set; }
        public bool isNewDeclaration { get; protected set; }

        public VariableAssignment (string variableName, bool isNewDeclaration)
        {
            this.variableName = variableName;
            this.isNewDeclaration = isNewDeclaration;
        }

        public override string ToString ()
        {
            return "VarAssign to " + variableName;
        }
    }
}

