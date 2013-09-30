using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForzaFramework.Model
{
    /// <summary>
    /// Model Class Implementation Sample
    /// </summary>
    public class ModelSample : ModelBase
    {
        public ModelSample(string title)
        {
            Title = title;
        }

        public string Title
        {
            get;
            private set;
        }

        public override bool Equals(ModelBase other)
        {
            return other.GetType().Equals(GetType()) && Id.Equals(other.Id);
        }
    }
}
