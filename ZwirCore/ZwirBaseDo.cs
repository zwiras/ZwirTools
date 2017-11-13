using System;

namespace ZwirCore
{
    public class ZwirBaseDo<TIdType>
    {
        private TIdType id;

        public TIdType Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
