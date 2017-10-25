using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMultiMessageToWeiboRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/message/SendMultiMessageToWeiboRequest", DoNotGenerateAcw=true)]
	public partial class SendMultiMessageToWeiboRequest : global::Com.Umeng.Socialize.Sina.Message.BaseRequest {


		static IntPtr multiMessage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMultiMessageToWeiboRequest']/field[@name='multiMessage']"
		[Register ("multiMessage")]
		public global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage MultiMessage {
			get {
				if (multiMessage_jfieldId == IntPtr.Zero)
					multiMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "multiMessage", "Lcom/sina/weibo/sdk/api/WeiboMultiMessage;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, multiMessage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (multiMessage_jfieldId == IntPtr.Zero)
					multiMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "multiMessage", "Lcom/sina/weibo/sdk/api/WeiboMultiMessage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, multiMessage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/message/SendMultiMessageToWeiboRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendMultiMessageToWeiboRequest); }
		}

		protected SendMultiMessageToWeiboRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMultiMessageToWeiboRequest']/constructor[@name='SendMultiMessageToWeiboRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SendMultiMessageToWeiboRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SendMultiMessageToWeiboRequest)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMultiMessageToWeiboRequest']/constructor[@name='SendMultiMessageToWeiboRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe SendMultiMessageToWeiboRequest (global::Android.OS.Bundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SendMultiMessageToWeiboRequest)) {
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
			global::Com.Umeng.Socialize.Sina.Message.SendMultiMessageToWeiboRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.SendMultiMessageToWeiboRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.message']/class[@name='SendMultiMessageToWeiboRequest']/method[@name='getType' and count(parameter)=0]"
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
