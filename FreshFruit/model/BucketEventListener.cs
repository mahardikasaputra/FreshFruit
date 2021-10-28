using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}
