using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Chat.Android.CustomCard
{
    [Register("CustomCard.LoadSpinerView")]
    public class LoadSpiner : LinearLayout
    {
        public LoadSpiner(Context context) : base(context)
        {
        }

        public LoadSpiner(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public LoadSpiner(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public LoadSpiner(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected LoadSpiner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}