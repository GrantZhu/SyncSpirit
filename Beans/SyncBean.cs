using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DiskFileSync.Beans
{
    class SyncBean<T>
    {
        private T fromInfo;

        public T FromInfo
        {
            get { return fromInfo; }
            set { fromInfo = value; }
        }
        private T toInfo;

        public T ToInfo
        {
            get { return toInfo; }
            set { toInfo = value; }
        }
        private SyncActionType syncType;

        internal SyncActionType SyncType
        {
            get { return syncType; }
            set { syncType = value; }
        }

        public SyncBean(T fInfo, T tInfo, SyncActionType type)
        {
            this.fromInfo = fInfo;
            this.toInfo = tInfo;
            this.syncType = type;
        }

        public string toString()
        {
            return "syncBean[" + this.toInfo + "," + this.toInfo + "," + this.syncType + "]";
        }
    }
}
