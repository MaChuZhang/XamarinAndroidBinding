using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Editorpage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.editorpage']/class[@name='ShareActivity']"
	[global::Android.Runtime.Register ("com/umeng/socialize/editorpage/ShareActivity", DoNotGenerateAcw=true)]
	public partial class ShareActivity : global::Android.App.Activity, global::Android.Views.View.IOnClickListener {


		static IntPtr mPreviewImageView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.editorpage']/class[@name='ShareActivity']/field[@name='mPreviewImageView']"
		[Register ("mPreviewImageView")]
		protected global::Android.Widget.ImageView MPreviewImageView {
			get {
				if (mPreviewImageView_jfieldId == IntPtr.Zero)
					mPreviewImageView_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewImageView", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPreviewImageView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreviewImageView_jfieldId == IntPtr.Zero)
					mPreviewImageView_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewImageView", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreviewImageView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/editorpage/ShareActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareActivity); }
		}

		protected ShareActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.editorpage']/class[@name='ShareActivity']/constructor[@name='ShareActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShareActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ShareActivity)) {
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

		static Delegate cb_onCancel_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCancel_Landroid_view_View_Handler ()
		{
			if (cb_onCancel_Landroid_view_View_ == null)
				cb_onCancel_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancel_Landroid_view_View_);
			return cb_onCancel_Landroid_view_View_;
		}

		static void n_OnCancel_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Editorpage.ShareActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Editorpage.ShareActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCancel_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/class[@name='ShareActivity']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onCancel", "(Landroid/view/View;)V", "GetOnCancel_Landroid_view_View_Handler")]
		public virtual unsafe void OnCancel (global::Android.Views.View p0)
		{
			if (id_onCancel_Landroid_view_View_ == IntPtr.Zero)
				id_onCancel_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancel", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Editorpage.ShareActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Editorpage.ShareActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/class[@name='ShareActivity']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_safeClose;
#pragma warning disable 0169
		static Delegate GetSafeCloseHandler ()
		{
			if (cb_safeClose == null)
				cb_safeClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SafeClose);
			return cb_safeClose;
		}

		static void n_SafeClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Editorpage.ShareActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Editorpage.ShareActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SafeClose ();
		}
#pragma warning restore 0169

		static IntPtr id_safeClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/class[@name='ShareActivity']/method[@name='safeClose' and count(parameter)=0]"
		[Register ("safeClose", "()V", "GetSafeCloseHandler")]
		protected virtual unsafe void SafeClose ()
		{
			if (id_safeClose == IntPtr.Zero)
				id_safeClose = JNIEnv.GetMethodID (class_ref, "safeClose", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_safeClose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "safeClose", "()V"));
			} finally {
			}
		}

	}
}
