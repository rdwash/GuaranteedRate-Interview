﻿using System.Collections.Generic;

namespace AttendeeImport.Common.Types
{
    public static class DelimeterTypes
    {
        public static Dictionary<string, char> DelimeterTypesDict = new Dictionary<string, char>()
        {
            {"commas", ','},
            {"pipes", '|'},
            {"space", ' '}
        };
    }    
}