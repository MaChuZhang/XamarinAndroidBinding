using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Editorpage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']"
	[Register ("com/umeng/socialize/editorpage/IEditor", "", "Com.Umeng.Socialize.Editorpage.IEditorInvoker")]
	public partial interface IEditor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']/method[@name='getEditable' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent']]"
		[Register ("getEditable", "(Lcom/umeng/socialize/ShareContent;)Landroid/os/Bundle;", "GetGetEditable_Lcom_umeng_socialize_ShareContent_Handler:Com.Umeng.Socialize.Editorpage.IEditorInvoker, UMeng")]
		global::Android.OS.Bundle GetEditable (global::Com.Umeng.Socialize.ShareContent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']/method[@name='getResult' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getResult", "(Lcom/umeng/socialize/ShareContent;Landroid/os/Bundle;)Lcom/umeng/socialize/ShareContent;", "GetGetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_Handler:Com.Umeng.Socialize.Editorpage.IEditorInvoker, UMeng")]
		global::Com.Umeng.Socialize.ShareContent GetResult (global::Com.Umeng.Socialize.ShareContent p0, global::Android.OS.Bundle p1);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/editorpage/IEditor", DoNotGenerateAcw=true)]
	internal class IEditorInvoker : global::Java.Lang.Object, IEditor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/editorpage/IEditor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEditorInvoker); }
		}

		IntPtr class_ref;

		public static IEditor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEditor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.editorpage.IEditor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEditorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getEditable_Lcom_umeng_socialize_ShareContent_;
#pragma warning disable 0169
		static Delegate GetGetEditable_Lcom_umeng_socialize_ShareContent_Handler ()
		{
			if (cb_getEditable_Lcom_umeng_socialize_ShareContent_ == null)
				cb_getEditable_Lcom_umeng_socialize_ShareContent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEditable_Lcom_umeng_socialize_ShareContent_);
			return cb_getEditable_Lcom_umeng_socialize_ShareContent_;
		}

		static IntPtr n_GetEditable_Lcom_umeng_socialize_ShareContent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Editorpage.IEditor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Editorpage.IEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEditable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEditable_Lcom_umeng_socialize_ShareContent_;
		public unsafe global::Android.OS.Bundle GetEditable (global::Com.Umeng.Socialize.ShareContent p0)
		{
			if (id_getEditable_Lcom_umeng_socialize_ShareContent_ == IntPtr.Zero)
				id_getEditable_Lcom_umeng_socialize_ShareContent_ = JNIEnv.GetMethodID (class_ref, "getEditable", "(Lcom/umeng/socialize/ShareContent;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEditable_Lcom_umeng_socialize_ShareContent_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_Handler ()
		{
			if (cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ == null)
				cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_);
			return cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_;
		}

		static IntPtr n_GetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Editorpage.IEditor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Editorpage.IEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResult (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_;
		public unsafe global::Com.Umeng.Socialize.ShareContent GetResult (global::Com.Umeng.Socialize.ShareContent p0, global::Android.OS.Bundle p1)
		{
			if (id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getResult", "(Lcom/umeng/socialize/ShareContent;Landroid/os/Bundle;)Lcom/umeng/socialize/ShareContent;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Com.Umeng.Socialize.ShareContent __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
