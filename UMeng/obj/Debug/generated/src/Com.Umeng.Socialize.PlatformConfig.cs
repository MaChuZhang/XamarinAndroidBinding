using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']"
	[global::Android.Runtime.Register ("com/umeng/socialize/PlatformConfig", DoNotGenerateAcw=true)]
	public partial class PlatformConfig : global::Java.Lang.Object {


		static IntPtr configs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/field[@name='configs']"
		[Register ("configs")]
		public static global::System.Collections.IDictionary Configs {
			get {
				if (configs_jfieldId == IntPtr.Zero)
					configs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "configs", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, configs_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (configs_jfieldId == IntPtr.Zero)
					configs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "configs", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, configs_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']"
		[global::Android.Runtime.Register ("com/umeng/socialize/PlatformConfig$APPIDPlatform", DoNotGenerateAcw=true)]
		public partial class APPIDPlatform : global::Java.Lang.Object, global::Com.Umeng.Socialize.PlatformConfig.IPlatform {


			static IntPtr appId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/field[@name='appId']"
			[Register ("appId")]
			public string AppId {
				get {
					if (appId_jfieldId == IntPtr.Zero)
						appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (appId_jfieldId == IntPtr.Zero)
						appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr appkey_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/field[@name='appkey']"
			[Register ("appkey")]
			public string Appkey {
				get {
					if (appkey_jfieldId == IntPtr.Zero)
						appkey_jfieldId = JNIEnv.GetFieldID (class_ref, "appkey", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appkey_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (appkey_jfieldId == IntPtr.Zero)
						appkey_jfieldId = JNIEnv.GetFieldID (class_ref, "appkey", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appkey_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr redirectUrl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/field[@name='redirectUrl']"
			[Register ("redirectUrl")]
			public string RedirectUrl {
				get {
					if (redirectUrl_jfieldId == IntPtr.Zero)
						redirectUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "redirectUrl", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, redirectUrl_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (redirectUrl_jfieldId == IntPtr.Zero)
						redirectUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "redirectUrl", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, redirectUrl_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/PlatformConfig$APPIDPlatform", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (APPIDPlatform); }
			}

			protected APPIDPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/constructor[@name='PlatformConfig.APPIDPlatform' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
			[Register (".ctor", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "")]
			public unsafe APPIDPlatform (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (APPIDPlatform)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				} finally {
				}
			}

			static Delegate cb_isConfigured;
#pragma warning disable 0169
			static Delegate GetIsConfiguredHandler ()
			{
				if (cb_isConfigured == null)
					cb_isConfigured = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConfigured);
				return cb_isConfigured;
			}

			static bool n_IsConfigured (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.PlatformConfig.APPIDPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.APPIDPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsConfigured;
			}
#pragma warning restore 0169

			static IntPtr id_isConfigured;
			public virtual unsafe bool IsConfigured {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/method[@name='isConfigured' and count(parameter)=0]"
				[Register ("isConfigured", "()Z", "GetIsConfiguredHandler")]
				get {
					if (id_isConfigured == IntPtr.Zero)
						id_isConfigured = JNIEnv.GetMethodID (class_ref, "isConfigured", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConfigured);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConfigured", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.PlatformConfig.APPIDPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.APPIDPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual unsafe global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_parse_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetParse_Lorg_json_JSONObject_Handler ()
			{
				if (cb_parse_Lorg_json_JSONObject_ == null)
					cb_parse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Lorg_json_JSONObject_);
				return cb_parse_Lorg_json_JSONObject_;
			}

			static void n_Parse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Umeng.Socialize.PlatformConfig.APPIDPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.APPIDPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Parse (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parse_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.APPIDPlatform']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("parse", "(Lorg/json/JSONObject;)V", "GetParse_Lorg_json_JSONObject_Handler")]
			public virtual unsafe void Parse (global::Org.Json.JSONObject p0)
			{
				if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_parse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']"
		[global::Android.Runtime.Register ("com/umeng/socialize/PlatformConfig$CustomPlatform", DoNotGenerateAcw=true)]
		public partial class CustomPlatform : global::Java.Lang.Object, global::Com.Umeng.Socialize.PlatformConfig.IPlatform {


			static IntPtr appId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']/field[@name='appId']"
			[Register ("appId")]
			public string AppId {
				get {
					if (appId_jfieldId == IntPtr.Zero)
						appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (appId_jfieldId == IntPtr.Zero)
						appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr appkey_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']/field[@name='appkey']"
			[Register ("appkey")]
			public string Appkey {
				get {
					if (appkey_jfieldId == IntPtr.Zero)
						appkey_jfieldId = JNIEnv.GetFieldID (class_ref, "appkey", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appkey_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (appkey_jfieldId == IntPtr.Zero)
						appkey_jfieldId = JNIEnv.GetFieldID (class_ref, "appkey", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appkey_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/PlatformConfig$CustomPlatform", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CustomPlatform); }
			}

			protected CustomPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']/constructor[@name='PlatformConfig.CustomPlatform' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
			[Register (".ctor", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "")]
			public unsafe CustomPlatform (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CustomPlatform)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				} finally {
				}
			}

			static Delegate cb_isConfigured;
#pragma warning disable 0169
			static Delegate GetIsConfiguredHandler ()
			{
				if (cb_isConfigured == null)
					cb_isConfigured = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConfigured);
				return cb_isConfigured;
			}

			static bool n_IsConfigured (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.PlatformConfig.CustomPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.CustomPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsConfigured;
			}
#pragma warning restore 0169

			static IntPtr id_isConfigured;
			public virtual unsafe bool IsConfigured {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']/method[@name='isConfigured' and count(parameter)=0]"
				[Register ("isConfigured", "()Z", "GetIsConfiguredHandler")]
				get {
					if (id_isConfigured == IntPtr.Zero)
						id_isConfigured = JNIEnv.GetMethodID (class_ref, "isConfigured", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConfigured);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConfigured", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.PlatformConfig.CustomPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.CustomPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual unsafe global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_parse_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetParse_Lorg_json_JSONObject_Handler ()
			{
				if (cb_parse_Lorg_json_JSONObject_ == null)
					cb_parse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Lorg_json_JSONObject_);
				return cb_parse_Lorg_json_JSONObject_;
			}

			static void n_Parse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Umeng.Socialize.PlatformConfig.CustomPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.CustomPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Parse (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parse_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig.CustomPlatform']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("parse", "(Lorg/json/JSONObject;)V", "GetParse_Lorg_json_JSONObject_Handler")]
			public virtual unsafe void Parse (global::Org.Json.JSONObject p0)
			{
				if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_parse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='PlatformConfig.Platform']"
		[Register ("com/umeng/socialize/PlatformConfig$Platform", "", "Com.Umeng.Socialize.PlatformConfig/IPlatformInvoker")]
		public partial interface IPlatform : IJavaObject {

			bool IsConfigured {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='PlatformConfig.Platform']/method[@name='isConfigured' and count(parameter)=0]"
				[Register ("isConfigured", "()Z", "GetIsConfiguredHandler:Com.Umeng.Socialize.PlatformConfig/IPlatformInvoker, UMeng")] get;
			}

			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='PlatformConfig.Platform']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;", "GetGetNameHandler:Com.Umeng.Socialize.PlatformConfig/IPlatformInvoker, UMeng")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='PlatformConfig.Platform']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("parse", "(Lorg/json/JSONObject;)V", "GetParse_Lorg_json_JSONObject_Handler:Com.Umeng.Socialize.PlatformConfig/IPlatformInvoker, UMeng")]
			void Parse (global::Org.Json.JSONObject p0);

		}

		[global::Android.Runtime.Register ("com/umeng/socialize/PlatformConfig$Platform", DoNotGenerateAcw=true)]
		internal class IPlatformInvoker : global::Java.Lang.Object, IPlatform {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/PlatformConfig$Platform");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPlatformInvoker); }
			}

			IntPtr class_ref;

			public static IPlatform GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPlatform> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.PlatformConfig.Platform"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPlatformInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_isConfigured;
#pragma warning disable 0169
			static Delegate GetIsConfiguredHandler ()
			{
				if (cb_isConfigured == null)
					cb_isConfigured = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConfigured);
				return cb_isConfigured;
			}

			static bool n_IsConfigured (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.PlatformConfig.IPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsConfigured;
			}
#pragma warning restore 0169

			IntPtr id_isConfigured;
			public unsafe bool IsConfigured {
				get {
					if (id_isConfigured == IntPtr.Zero)
						id_isConfigured = JNIEnv.GetMethodID (class_ref, "isConfigured", "()Z");
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConfigured);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.PlatformConfig.IPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Name);
			}
#pragma warning restore 0169

			IntPtr id_getName;
			public unsafe global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Name {
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;");
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_parse_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetParse_Lorg_json_JSONObject_Handler ()
			{
				if (cb_parse_Lorg_json_JSONObject_ == null)
					cb_parse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Lorg_json_JSONObject_);
				return cb_parse_Lorg_json_JSONObject_;
			}

			static void n_Parse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Umeng.Socialize.PlatformConfig.IPlatform __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Parse (p0);
			}
#pragma warning restore 0169

			IntPtr id_parse_Lorg_json_JSONObject_;
			public unsafe void Parse (global::Org.Json.JSONObject p0)
			{
				if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_parse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_json_JSONObject_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/PlatformConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlatformConfig); }
		}

		protected PlatformConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/constructor[@name='PlatformConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlatformConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PlatformConfig)) {
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

		static IntPtr id_getPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='getPlatform' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("getPlatform", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/PlatformConfig$Platform;", "")]
		public static unsafe global::Com.Umeng.Socialize.PlatformConfig.IPlatform GetPlatform (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_getPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_getPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetStaticMethodID (class_ref, "getPlatform", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/PlatformConfig$Platform;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.PlatformConfig.IPlatform __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeBlank_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='removeBlank' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeBlank", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveBlank (string p0)
		{
			if (id_removeBlank_Ljava_lang_String_ == IntPtr.Zero)
				id_removeBlank_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeBlank", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeBlank_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setAlipay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setAlipay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAlipay", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAlipay (string p0)
		{
			if (id_setAlipay_Ljava_lang_String_ == IntPtr.Zero)
				id_setAlipay_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAlipay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlipay_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setDing_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setDing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDing", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetDing (string p0)
		{
			if (id_setDing_Ljava_lang_String_ == IntPtr.Zero)
				id_setDing_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setDing", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDing_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setDropbox_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setDropbox' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDropbox", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetDropbox (string p0, string p1)
		{
			if (id_setDropbox_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setDropbox_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setDropbox", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDropbox_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setKakao_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setKakao' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKakao", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetKakao (string p0)
		{
			if (id_setKakao_Ljava_lang_String_ == IntPtr.Zero)
				id_setKakao_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setKakao", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setKakao_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setLaiwang_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setLaiwang' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLaiwang", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetLaiwang (string p0, string p1)
		{
			if (id_setLaiwang_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setLaiwang_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setLaiwang", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLaiwang_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setPinterest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setPinterest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPinterest", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetPinterest (string p0)
		{
			if (id_setPinterest_Ljava_lang_String_ == IntPtr.Zero)
				id_setPinterest_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setPinterest", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPinterest_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setQQZone_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setQQZone' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setQQZone", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetQQZone (string p0, string p1)
		{
			if (id_setQQZone_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setQQZone_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setQQZone", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setQQZone_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setSinaWeibo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setSinaWeibo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setSinaWeibo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetSinaWeibo (string p0, string p1, string p2)
		{
			if (id_setSinaWeibo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setSinaWeibo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setSinaWeibo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSinaWeibo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setTwitter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setTwitter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTwitter", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetTwitter (string p0, string p1)
		{
			if (id_setTwitter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setTwitter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setTwitter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTwitter_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setVKontakte_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setVKontakte' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setVKontakte", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetVKontakte (string p0, string p1)
		{
			if (id_setVKontakte_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setVKontakte_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setVKontakte", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVKontakte_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setWeixin_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setWeixin' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setWeixin", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetWeixin (string p0, string p1)
		{
			if (id_setWeixin_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setWeixin_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setWeixin", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setWeixin_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setYixin_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setYixin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setYixin", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetYixin (string p0)
		{
			if (id_setYixin_Ljava_lang_String_ == IntPtr.Zero)
				id_setYixin_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setYixin", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setYixin_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setYnote_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='PlatformConfig']/method[@name='setYnote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setYnote", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetYnote (string p0)
		{
			if (id_setYnote_Ljava_lang_String_ == IntPtr.Zero)
				id_setYnote_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setYnote", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setYnote_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
