using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Shareboard.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']"
	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializePagerAdapter", DoNotGenerateAcw=true)]
	public abstract partial class SocializePagerAdapter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/field[@name='POSITION_NONE']"
		[Register ("POSITION_NONE")]
		public const int PositionNone = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/field[@name='POSITION_UNCHANGED']"
		[Register ("POSITION_UNCHANGED")]
		public const int PositionUnchanged = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/shareboard/widgets/SocializePagerAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializePagerAdapter); }
		}

		protected SocializePagerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/constructor[@name='SocializePagerAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializePagerAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializePagerAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public abstract int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")] get;
		}

		static Delegate cb_destroyItem_Landroid_view_View_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDestroyItem_Landroid_view_View_ILjava_lang_Object_Handler ()
		{
			if (cb_destroyItem_Landroid_view_View_ILjava_lang_Object_ == null)
				cb_destroyItem_Landroid_view_View_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_DestroyItem_Landroid_view_View_ILjava_lang_Object_);
			return cb_destroyItem_Landroid_view_View_ILjava_lang_Object_;
		}

		static void n_DestroyItem_Landroid_view_View_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DestroyItem (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_destroyItem_Landroid_view_View_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='destroyItem' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("destroyItem", "(Landroid/view/View;ILjava/lang/Object;)V", "GetDestroyItem_Landroid_view_View_ILjava_lang_Object_Handler")]
		public virtual unsafe void DestroyItem (global::Android.Views.View p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_destroyItem_Landroid_view_View_ILjava_lang_Object_ == IntPtr.Zero)
				id_destroyItem_Landroid_view_View_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "destroyItem", "(Landroid/view/View;ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyItem_Landroid_view_View_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyItem", "(Landroid/view/View;ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler ()
		{
			if (cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ == null)
				cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_DestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_);
			return cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
		}

		static void n_DestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DestroyItem (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='destroyItem' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("destroyItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "GetDestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler")]
		public virtual unsafe void DestroyItem (global::Android.Views.ViewGroup p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ == IntPtr.Zero)
				id_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "destroyItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_finishUpdate_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetFinishUpdate_Landroid_view_View_Handler ()
		{
			if (cb_finishUpdate_Landroid_view_View_ == null)
				cb_finishUpdate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FinishUpdate_Landroid_view_View_);
			return cb_finishUpdate_Landroid_view_View_;
		}

		static void n_FinishUpdate_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FinishUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_finishUpdate_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='finishUpdate' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Obsolete (@"deprecated")]
		[Register ("finishUpdate", "(Landroid/view/View;)V", "GetFinishUpdate_Landroid_view_View_Handler")]
		public virtual unsafe void FinishUpdate (global::Android.Views.View p0)
		{
			if (id_finishUpdate_Landroid_view_View_ == IntPtr.Zero)
				id_finishUpdate_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "finishUpdate", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishUpdate_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishUpdate", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_finishUpdate_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetFinishUpdate_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_finishUpdate_Landroid_view_ViewGroup_ == null)
				cb_finishUpdate_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FinishUpdate_Landroid_view_ViewGroup_);
			return cb_finishUpdate_Landroid_view_ViewGroup_;
		}

		static void n_FinishUpdate_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FinishUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_finishUpdate_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='finishUpdate' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("finishUpdate", "(Landroid/view/ViewGroup;)V", "GetFinishUpdate_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe void FinishUpdate (global::Android.Views.ViewGroup p0)
		{
			if (id_finishUpdate_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_finishUpdate_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "finishUpdate", "(Landroid/view/ViewGroup;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishUpdate_Landroid_view_ViewGroup_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishUpdate", "(Landroid/view/ViewGroup;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getItemPosition_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetItemPosition_Ljava_lang_Object_Handler ()
		{
			if (cb_getItemPosition_Ljava_lang_Object_ == null)
				cb_getItemPosition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetItemPosition_Ljava_lang_Object_);
			return cb_getItemPosition_Ljava_lang_Object_;
		}

		static int n_GetItemPosition_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetItemPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getItemPosition_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='getItemPosition' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getItemPosition", "(Ljava/lang/Object;)I", "GetGetItemPosition_Ljava_lang_Object_Handler")]
		public virtual unsafe int GetItemPosition (global::Java.Lang.Object p0)
		{
			if (id_getItemPosition_Ljava_lang_Object_ == IntPtr.Zero)
				id_getItemPosition_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getItemPosition", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemPosition_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemPosition", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPageTitle_I;
#pragma warning disable 0169
		static Delegate GetGetPageTitle_IHandler ()
		{
			if (cb_getPageTitle_I == null)
				cb_getPageTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPageTitle_I);
			return cb_getPageTitle_I;
		}

		static IntPtr n_GetPageTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.GetPageTitleFormatted (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPageTitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='getPageTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageTitle", "(I)Ljava/lang/CharSequence;", "GetGetPageTitle_IHandler")]
		public virtual unsafe global::Java.Lang.ICharSequence GetPageTitleFormatted (int p0)
		{
			if (id_getPageTitle_I == IntPtr.Zero)
				id_getPageTitle_I = JNIEnv.GetMethodID (class_ref, "getPageTitle", "(I)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageTitle_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageTitle", "(I)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string GetPageTitle (int p0)
		{
			global::Java.Lang.ICharSequence __result = GetPageTitleFormatted (p0);
			return __result == null ? null : __result.ToString ();
		}

		static Delegate cb_getPageWidth_I;
#pragma warning disable 0169
		static Delegate GetGetPageWidth_IHandler ()
		{
			if (cb_getPageWidth_I == null)
				cb_getPageWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetPageWidth_I);
			return cb_getPageWidth_I;
		}

		static float n_GetPageWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPageWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='getPageWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageWidth", "(I)F", "GetGetPageWidth_IHandler")]
		public virtual unsafe float GetPageWidth (int p0)
		{
			if (id_getPageWidth_I == IntPtr.Zero)
				id_getPageWidth_I = JNIEnv.GetMethodID (class_ref, "getPageWidth", "(I)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageWidth_I, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageWidth", "(I)F"), __args);
			} finally {
			}
		}

		static Delegate cb_instantiateItem_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetInstantiateItem_Landroid_view_View_IHandler ()
		{
			if (cb_instantiateItem_Landroid_view_View_I == null)
				cb_instantiateItem_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_InstantiateItem_Landroid_view_View_I);
			return cb_instantiateItem_Landroid_view_View_I;
		}

		static IntPtr n_InstantiateItem_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InstantiateItem (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_instantiateItem_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='instantiateItem' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("instantiateItem", "(Landroid/view/View;I)Ljava/lang/Object;", "GetInstantiateItem_Landroid_view_View_IHandler")]
		public virtual unsafe global::Java.Lang.Object InstantiateItem (global::Android.Views.View p0, int p1)
		{
			if (id_instantiateItem_Landroid_view_View_I == IntPtr.Zero)
				id_instantiateItem_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "instantiateItem", "(Landroid/view/View;I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_instantiateItem_Landroid_view_View_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "instantiateItem", "(Landroid/view/View;I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_instantiateItem_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetInstantiateItem_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_instantiateItem_Landroid_view_ViewGroup_I == null)
				cb_instantiateItem_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_InstantiateItem_Landroid_view_ViewGroup_I);
			return cb_instantiateItem_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_InstantiateItem_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InstantiateItem (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_instantiateItem_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='instantiateItem' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("instantiateItem", "(Landroid/view/ViewGroup;I)Ljava/lang/Object;", "GetInstantiateItem_Landroid_view_ViewGroup_IHandler")]
		public virtual unsafe global::Java.Lang.Object InstantiateItem (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_instantiateItem_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_instantiateItem_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "instantiateItem", "(Landroid/view/ViewGroup;I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_instantiateItem_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "instantiateItem", "(Landroid/view/ViewGroup;I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler ()
		{
			if (cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == null)
				cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_);
			return cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		}

		static bool n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsViewFromObject (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='isViewFromObject' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public abstract bool IsViewFromObject (global::Android.Views.View p0, global::Java.Lang.Object p1);

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			if (id_notifyDataSetChanged == IntPtr.Zero)
				id_notifyDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDataSetChanged);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='registerDataSetObserver' and count(parameter)=1 and parameter[1][@type='android.database.DataSetObserver']]"
		[Register ("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public virtual unsafe void RegisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerDataSetObserver_Landroid_database_DataSetObserver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_;
#pragma warning disable 0169
		static Delegate GetRestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_Handler ()
		{
			if (cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ == null)
				cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_);
			return cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_;
		}

		static void n_RestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ClassLoader p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='restoreState' and count(parameter)=2 and parameter[1][@type='android.os.Parcelable'] and parameter[2][@type='java.lang.ClassLoader']]"
		[Register ("restoreState", "(Landroid/os/Parcelable;Ljava/lang/ClassLoader;)V", "GetRestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_Handler")]
		public virtual unsafe void RestoreState (global::Android.OS.IParcelable p0, global::Java.Lang.ClassLoader p1)
		{
			if (id_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ == IntPtr.Zero)
				id_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ = JNIEnv.GetMethodID (class_ref, "restoreState", "(Landroid/os/Parcelable;Ljava/lang/ClassLoader;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreState", "(Landroid/os/Parcelable;Ljava/lang/ClassLoader;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_saveState;
#pragma warning disable 0169
		static Delegate GetSaveStateHandler ()
		{
			if (cb_saveState == null)
				cb_saveState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SaveState);
			return cb_saveState;
		}

		static IntPtr n_SaveState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SaveState ());
		}
#pragma warning restore 0169

		static IntPtr id_saveState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='saveState' and count(parameter)=0]"
		[Register ("saveState", "()Landroid/os/Parcelable;", "GetSaveStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable SaveState ()
		{
			if (id_saveState == IntPtr.Zero)
				id_saveState = JNIEnv.GetMethodID (class_ref, "saveState", "()Landroid/os/Parcelable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetPrimaryItem_Landroid_view_View_ILjava_lang_Object_Handler ()
		{
			if (cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_ == null)
				cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetPrimaryItem_Landroid_view_View_ILjava_lang_Object_);
			return cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_;
		}

		static void n_SetPrimaryItem_Landroid_view_View_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetPrimaryItem (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='setPrimaryItem' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("setPrimaryItem", "(Landroid/view/View;ILjava/lang/Object;)V", "GetSetPrimaryItem_Landroid_view_View_ILjava_lang_Object_Handler")]
		public virtual unsafe void SetPrimaryItem (global::Android.Views.View p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_ == IntPtr.Zero)
				id_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setPrimaryItem", "(Landroid/view/View;ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrimaryItem", "(Landroid/view/View;ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler ()
		{
			if (cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ == null)
				cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_);
			return cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
		}

		static void n_SetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetPrimaryItem (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='setPrimaryItem' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setPrimaryItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "GetSetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler")]
		public virtual unsafe void SetPrimaryItem (global::Android.Views.ViewGroup p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ == IntPtr.Zero)
				id_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setPrimaryItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrimaryItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startUpdate_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetStartUpdate_Landroid_view_View_Handler ()
		{
			if (cb_startUpdate_Landroid_view_View_ == null)
				cb_startUpdate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartUpdate_Landroid_view_View_);
			return cb_startUpdate_Landroid_view_View_;
		}

		static void n_StartUpdate_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startUpdate_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='startUpdate' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Obsolete (@"deprecated")]
		[Register ("startUpdate", "(Landroid/view/View;)V", "GetStartUpdate_Landroid_view_View_Handler")]
		public virtual unsafe void StartUpdate (global::Android.Views.View p0)
		{
			if (id_startUpdate_Landroid_view_View_ == IntPtr.Zero)
				id_startUpdate_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "startUpdate", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUpdate_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startUpdate", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startUpdate_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetStartUpdate_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_startUpdate_Landroid_view_ViewGroup_ == null)
				cb_startUpdate_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartUpdate_Landroid_view_ViewGroup_);
			return cb_startUpdate_Landroid_view_ViewGroup_;
		}

		static void n_StartUpdate_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startUpdate_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='startUpdate' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("startUpdate", "(Landroid/view/ViewGroup;)V", "GetStartUpdate_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe void StartUpdate (global::Android.Views.ViewGroup p0)
		{
			if (id_startUpdate_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_startUpdate_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "startUpdate", "(Landroid/view/ViewGroup;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUpdate_Landroid_view_ViewGroup_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startUpdate", "(Landroid/view/ViewGroup;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='unregisterDataSetObserver' and count(parameter)=1 and parameter[1][@type='android.database.DataSetObserver']]"
		[Register ("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public virtual unsafe void UnregisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializePagerAdapter", DoNotGenerateAcw=true)]
	internal partial class SocializePagerAdapterInvoker : SocializePagerAdapter {

		public SocializePagerAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializePagerAdapterInvoker); }
		}

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
				} finally {
				}
			}
		}

		static IntPtr id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializePagerAdapter']/method[@name='isViewFromObject' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public override unsafe bool IsViewFromObject (global::Android.Views.View p0, global::Java.Lang.Object p1)
		{
			if (id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == IntPtr.Zero)
				id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
