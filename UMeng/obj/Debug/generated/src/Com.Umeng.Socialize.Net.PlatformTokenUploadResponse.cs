using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='PlatformTokenUploadResponse']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/PlatformTokenUploadResponse", DoNotGenerateAcw=true)]
	public partial class PlatformTokenUploadResponse : global::Com.Umeng.Socialize.Net.Base.SocializeReseponse {


		static IntPtr mExpiresIn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='PlatformTokenUploadResponse']/field[@name='mExpiresIn']"
		[Register ("mExpiresIn")]
		public string MExpiresIn {
			get {
				if (mExpiresIn_jfieldId == IntPtr.Zero)
					mExpiresIn_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpiresIn", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mExpiresIn_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mExpiresIn_jfieldId == IntPtr.Zero)
					mExpiresIn_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpiresIn", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mExpiresIn_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTencentUid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='PlatformTokenUploadResponse']/field[@name='mTencentUid']"
		[Register ("mTencentUid")]
		public string MTencentUid {
			get {
				if (mTencentUid_jfieldId == IntPtr.Zero)
					mTencentUid_jfieldId = JNIEnv.GetFieldID (class_ref, "mTencentUid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTencentUid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTencentUid_jfieldId == IntPtr.Zero)
					mTencentUid_jfieldId = JNIEnv.GetFieldID (class_ref, "mTencentUid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTencentUid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/PlatformTokenUploadResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlatformTokenUploadResponse); }
		}

		protected PlatformTokenUploadResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='PlatformTokenUploadResponse']/constructor[@name='PlatformTokenUploadResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", "")]
		public unsafe PlatformTokenUploadResponse (global::Java.Lang.Integer p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PlatformTokenUploadResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

	}
}
