using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMessageToWeiboRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/message/SendMessageToWeiboRequest", DoNotGenerateAcw=true)]
	public partial class SendMessageToWeiboRequest : global::Com.Umeng.Socialize.Sina.Message.BaseRequest {


		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMessageToWeiboRequest']/field[@name='message']"
		[Register ("message")]
		public global::Android.OS.Bundle Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Landroid/os/Bundle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Landroid/os/Bundle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/message/SendMessageToWeiboRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendMessageToWeiboRequest); }
		}

		protected SendMessageToWeiboRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMessageToWeiboRequest']/constructor[@name='SendMessageToWeiboRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SendMessageToWeiboRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SendMessageToWeiboRequest)) {
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

		static IntPtr id_ctor_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMessageToWeiboRequest']/constructor[@name='SendMessageToWeiboRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe SendMessageToWeiboRequest (global::Android.OS.Bundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SendMessageToWeiboRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Bundle;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Message.SendMessageToWeiboRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.SendMessageToWeiboRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMessageToWeiboRequest']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

	}
}
