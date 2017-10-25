using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Sina.Weibo.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']"
	[global::Android.Runtime.Register ("com/sina/weibo/sdk/api/WeiboMultiMessage", DoNotGenerateAcw=true)]
	public sealed partial class WeiboMultiMessage : global::Java.Lang.Object {


		static IntPtr imageObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/field[@name='imageObject']"
		[Register ("imageObject")]
		public global::Com.Sina.Weibo.Sdk.Api.ImageObject ImageObject {
			get {
				if (imageObject_jfieldId == IntPtr.Zero)
					imageObject_jfieldId = JNIEnv.GetFieldID (class_ref, "imageObject", "Lcom/sina/weibo/sdk/api/ImageObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, imageObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.ImageObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageObject_jfieldId == IntPtr.Zero)
					imageObject_jfieldId = JNIEnv.GetFieldID (class_ref, "imageObject", "Lcom/sina/weibo/sdk/api/ImageObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imageObject_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mediaObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/field[@name='mediaObject']"
		[Register ("mediaObject")]
		public global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject MediaObject {
			get {
				if (mediaObject_jfieldId == IntPtr.Zero)
					mediaObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaObject", "Lcom/sina/weibo/sdk/api/BaseMediaObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mediaObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mediaObject_jfieldId == IntPtr.Zero)
					mediaObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaObject", "Lcom/sina/weibo/sdk/api/BaseMediaObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mediaObject_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr textObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/field[@name='textObject']"
		[Register ("textObject")]
		public global::Com.Sina.Weibo.Sdk.Api.TextObject TextObject {
			get {
				if (textObject_jfieldId == IntPtr.Zero)
					textObject_jfieldId = JNIEnv.GetFieldID (class_ref, "textObject", "Lcom/sina/weibo/sdk/api/TextObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, textObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.TextObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (textObject_jfieldId == IntPtr.Zero)
					textObject_jfieldId = JNIEnv.GetFieldID (class_ref, "textObject", "Lcom/sina/weibo/sdk/api/TextObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, textObject_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/sina/weibo/sdk/api/WeiboMultiMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeiboMultiMessage); }
		}

		internal WeiboMultiMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/constructor[@name='WeiboMultiMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WeiboMultiMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WeiboMultiMessage)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/constructor[@name='WeiboMultiMessage' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe WeiboMultiMessage (global::Android.OS.Bundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WeiboMultiMessage)) {
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

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "")]
		public unsafe bool CheckArgs ()
		{
			if (id_checkArgs == IntPtr.Zero)
				id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkArgs);
			} finally {
			}
		}

		static IntPtr id_toBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/method[@name='toBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("toBundle", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "")]
		public unsafe global::Android.OS.Bundle ToBundle (global::Android.OS.Bundle p0)
		{
			if (id_toBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_toBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "toBundle", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toObject_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='WeiboMultiMessage']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("toObject", "(Landroid/os/Bundle;)Lcom/sina/weibo/sdk/api/WeiboMultiMessage;", "")]
		public unsafe global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage ToObject (global::Android.OS.Bundle p0)
		{
			if (id_toObject_Landroid_os_Bundle_ == IntPtr.Zero)
				id_toObject_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "toObject", "(Landroid/os/Bundle;)Lcom/sina/weibo/sdk/api/WeiboMultiMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toObject_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
