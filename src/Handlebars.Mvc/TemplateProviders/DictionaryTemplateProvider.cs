﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandlebarsViewEngine.TemplateProviders
{
    /// <summary>
    /// Potentially use this for unit testing, to load a template and get it several times etc
    /// </summary>
    public class DictionaryTemplateProvider : ITemplateProvider
    {
        public bool Cache
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void RemoveWithPrefix(string prefix)
        {
            throw new NotImplementedException();
        }

        public string GetTemplate(string view)
        {
            throw new NotImplementedException();
        }

        public List<string> List()
        {
            throw new NotImplementedException();
        }

        public List<string> List(string prefix)
        {
            throw new NotImplementedException();
        }

        public string Get(string view)
        {
            throw new NotImplementedException();
        }


        public string Get(string version, string view)
        {
            throw new NotImplementedException();
        }
    }
}
