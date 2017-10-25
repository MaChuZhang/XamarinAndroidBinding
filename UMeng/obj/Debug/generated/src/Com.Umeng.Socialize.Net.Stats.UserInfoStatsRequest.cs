using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/UserInfoStatsRequest", DoNotGenerateAcw=true)]
	public partial class UserInfoStatsRequest : global::Com.Umeng.Socialize.Net.Stats.StatsRequest {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest.GetUserInfoLifecycle']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle", DoNotGenerateAcw=true)]
		protected internal sealed partial class GetUserInfoLifecycle : global::Java.Lang.Enum {


			static IntPtr END_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest.GetUserInfoLifecycle']/field[@name='END']"
			[Register ("END")]
			public static global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle End {
				get {
					if (END_jfieldId == IntPtr.Zero)
						END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END", "Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr START_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest.GetUserInfoLifecycle']/field[@name='START']"
			[Register ("START")]
			public static global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle Start {
				get {
					if (START_jfieldId == IntPtr.Zero)
						START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "START", "Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, START_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetUserInfoLifecycle); }
			}

			internal GetUserInfoLifecycle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest.GetUserInfoLifecycle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest.GetUserInfoLifecycle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;");
				try {
					return (global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/stats/UserInfoStatsRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserInfoStatsRequest); }
		}

		protected UserInfoStatsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest']/constructor[@name='UserInfoStatsRequest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class&lt;? extends com.umeng.socialize.net.base.SocializeReseponse&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public unsafe UserInfoStatsRequest (global::Android.Content.Context p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UserInfoStatsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		protected override unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_;
#pragma warning disable 0169
		static Delegate GetSetRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_Handler ()
		{
			if (cb_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_ == null)
				cb_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_);
			return cb_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_;
		}

		static void n_SetRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestPath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='UserInfoStatsRequest']/method[@name='setRequestPath' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.UserInfoStatsRequest.GetUserInfoLifecycle']]"
		[Register ("setRequestPath", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;)V", "GetSetRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_Handler")]
		protected virtual unsafe void SetRequestPath (global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest.GetUserInfoLifecycle p0)
		{
			if (id_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_ == IntPtr.Zero)
				id_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_ = JNIEnv.GetMethodID (class_ref, "setRequestPath", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestPath_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_GetUserInfoLifecycle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestPath", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest$GetUserInfoLifecycle;)V"), __args);
			} finally {
			}
		}

	}
}
