using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ForzaFramework.Model
{
    public abstract class ModelBase : ObservableObject, IEquatable<ModelBase>
    {
        //TODO: extract interface
        Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { Set("Id", ref _id, value); }
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public abstract bool Equals(ModelBase other);
    }
}
