using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/ShareStatsRequest", DoNotGenerateAcw=true)]
	public partial class ShareStatsRequest : global::Com.Umeng.Socialize.Net.Stats.StatsRequest {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest.ShareLifecycle']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle", DoNotGenerateAcw=true)]
		protected internal sealed partial class ShareLifecycle : global::Java.Lang.Enum {


			static IntPtr END_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest.ShareLifecycle']/field[@name='END']"
			[Register ("END")]
			public static global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle End {
				get {
					if (END_jfieldId == IntPtr.Zero)
						END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END", "Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr START_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest.ShareLifecycle']/field[@name='START']"
			[Register ("START")]
			public static global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle Start {
				get {
					if (START_jfieldId == IntPtr.Zero)
						START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "START", "Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, START_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShareLifecycle); }
			}

			internal ShareLifecycle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest.ShareLifecycle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest.ShareLifecycle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;");
				try {
					return (global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/stats/ShareStatsRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareStatsRequest); }
		}

		protected ShareStatsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest']/constructor[@name='ShareStatsRequest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class&lt;? extends com.umeng.socialize.net.base.SocializeReseponse&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public unsafe ShareStatsRequest (global::Android.Content.Context p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ShareStatsRequest)) {
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
			global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		protected override unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest']/method[@name='getPath' and count(parameter)=0]"
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

		static Delegate cb_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_;
#pragma warning disable 0169
		static Delegate GetSetRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_Handler ()
		{
			if (cb_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_ == null)
				cb_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_);
			return cb_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_;
		}

		static void n_SetRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestPath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='ShareStatsRequest']/method[@name='setRequestPath' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.ShareStatsRequest.ShareLifecycle']]"
		[Register ("setRequestPath", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;)V", "GetSetRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_Handler")]
		protected virtual unsafe void SetRequestPath (global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest.ShareLifecycle p0)
		{
			if (id_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_ == IntPtr.Zero)
				id_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_ = JNIEnv.GetMethodID (class_ref, "setRequestPath", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestPath_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ShareLifecycle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestPath", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest$ShareLifecycle;)V"), __args);
			} finally {
			}
		}

	}
}
