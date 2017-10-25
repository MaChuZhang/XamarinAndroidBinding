using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/base/SocializeReseponse", DoNotGenerateAcw=true)]
	public partial class SocializeReseponse : global::Com.Umeng.Socialize.Net.Utils.UResponse {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "SocializeReseponse";

		static IntPtr mJsonData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/field[@name='mJsonData']"
		[Register ("mJsonData")]
		protected global::Org.Json.JSONObject MJsonData {
			get {
				if (mJsonData_jfieldId == IntPtr.Zero)
					mJsonData_jfieldId = JNIEnv.GetFieldID (class_ref, "mJsonData", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mJsonData_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mJsonData_jfieldId == IntPtr.Zero)
					mJsonData_jfieldId = JNIEnv.GetFieldID (class_ref, "mJsonData", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mJsonData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMsg_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/field[@name='mMsg']"
		[Register ("mMsg")]
		public string MMsg {
			get {
				if (mMsg_jfieldId == IntPtr.Zero)
					mMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "mMsg", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMsg_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMsg_jfieldId == IntPtr.Zero)
					mMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "mMsg", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMsg_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/field[@name='mStCode']"
		[Register ("mStCode")]
		public int MStCode {
			get {
				if (mStCode_jfieldId == IntPtr.Zero)
					mStCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mStCode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mStCode_jfieldId);
			}
			set {
				if (mStCode_jfieldId == IntPtr.Zero)
					mStCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mStCode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStCode_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/base/SocializeReseponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeReseponse); }
		}

		protected SocializeReseponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/constructor[@name='SocializeReseponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe SocializeReseponse (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SocializeReseponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/constructor[@name='SocializeReseponse' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", "")]
		public unsafe SocializeReseponse (global::Java.Lang.Integer p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SocializeReseponse)) {
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

		static Delegate cb_isHttpOK;
#pragma warning disable 0169
		static Delegate GetIsHttpOKHandler ()
		{
			if (cb_isHttpOK == null)
				cb_isHttpOK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHttpOK);
			return cb_isHttpOK;
		}

		static bool n_IsHttpOK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHttpOK;
		}
#pragma warning restore 0169

		static IntPtr id_isHttpOK;
		public virtual unsafe bool IsHttpOK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/method[@name='isHttpOK' and count(parameter)=0]"
			[Register ("isHttpOK", "()Z", "GetIsHttpOKHandler")]
			get {
				if (id_isHttpOK == IntPtr.Zero)
					id_isHttpOK = JNIEnv.GetMethodID (class_ref, "isHttpOK", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHttpOK);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHttpOK", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOk;
#pragma warning disable 0169
		static Delegate GetIsOkHandler ()
		{
			if (cb_isOk == null)
				cb_isOk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOk);
			return cb_isOk;
		}

		static bool n_IsOk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOk;
		}
#pragma warning restore 0169

		static IntPtr id_isOk;
		public virtual unsafe bool IsOk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/method[@name='isOk' and count(parameter)=0]"
			[Register ("isOk", "()Z", "GetIsOkHandler")]
			get {
				if (id_isOk == IntPtr.Zero)
					id_isOk = JNIEnv.GetMethodID (class_ref, "isOk", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOk);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOk", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getJsonData;
#pragma warning disable 0169
		static Delegate GetGetJsonDataHandler ()
		{
			if (cb_getJsonData == null)
				cb_getJsonData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonData);
			return cb_getJsonData;
		}

		static IntPtr n_GetJsonData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsonData);
		}
#pragma warning restore 0169

		static IntPtr id_getJsonData;
		public virtual unsafe global::Org.Json.JSONObject JsonData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/method[@name='getJsonData' and count(parameter)=0]"
			[Register ("getJsonData", "()Lorg/json/JSONObject;", "GetGetJsonDataHandler")]
			get {
				if (id_getJsonData == IntPtr.Zero)
					id_getJsonData = JNIEnv.GetMethodID (class_ref, "getJsonData", "()Lorg/json/JSONObject;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJsonData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJsonData", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_parseJsonObject;
#pragma warning disable 0169
		static Delegate GetParseJsonObjectHandler ()
		{
			if (cb_parseJsonObject == null)
				cb_parseJsonObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ParseJsonObject);
			return cb_parseJsonObject;
		}

		static void n_ParseJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseJsonObject ();
		}
#pragma warning restore 0169

		static IntPtr id_parseJsonObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeReseponse']/method[@name='parseJsonObject' and count(parameter)=0]"
		[Register ("parseJsonObject", "()V", "GetParseJsonObjectHandler")]
		public virtual unsafe void ParseJsonObject ()
		{
			if (id_parseJsonObject == IntPtr.Zero)
				id_parseJsonObject = JNIEnv.GetMethodID (class_ref, "parseJsonObject", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseJsonObject);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseJsonObject", "()V"));
			} finally {
			}
		}

	}
}
