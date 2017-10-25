using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/StatsRequest", DoNotGenerateAcw=true)]
	public abstract partial class StatsRequest : global::Com.Umeng.Socialize.Net.Base.SocializeRequest {


		static IntPtr PARAMS_STATS_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsRequest']/field[@name='PARAMS_STATS_TYPE']"
		[Register ("PARAMS_STATS_TYPE")]
		protected static string ParamsStatsType {
			get {
				if (PARAMS_STATS_TYPE_jfieldId == IntPtr.Zero)
					PARAMS_STATS_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARAMS_STATS_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARAMS_STATS_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PARAMS_STATS_TYPE_jfieldId == IntPtr.Zero)
					PARAMS_STATS_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARAMS_STATS_TYPE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PARAMS_STATS_TYPE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRequestPath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsRequest']/field[@name='mRequestPath']"
		[Register ("mRequestPath")]
		protected string MRequestPath {
			get {
				if (mRequestPath_jfieldId == IntPtr.Zero)
					mRequestPath_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestPath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRequestPath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRequestPath_jfieldId == IntPtr.Zero)
					mRequestPath_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestPath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRequestPath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/stats/StatsRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatsRequest); }
		}

		protected StatsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ILcom_umeng_socialize_net_utils_URequest_RequestMethod_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsRequest']/constructor[@name='StatsRequest' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;? extends com.umeng.socialize.net.base.SocializeReseponse&gt;'] and parameter[4][@type='int'] and parameter[5][@type='com.umeng.socialize.net.utils.URequest.RequestMethod']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;ILcom/umeng/socialize/net/utils/URequest$RequestMethod;)V", "")]
		public unsafe StatsRequest (global::Android.Content.Context p0, string p1, global::Java.Lang.Class p2, int p3, global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (StatsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;ILcom/umeng/socialize/net/utils/URequest$RequestMethod;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;ILcom/umeng/socialize/net/utils/URequest$RequestMethod;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ILcom_umeng_socialize_net_utils_URequest_RequestMethod_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ILcom_umeng_socialize_net_utils_URequest_RequestMethod_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;ILcom/umeng/socialize/net/utils/URequest$RequestMethod;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ILcom_umeng_socialize_net_utils_URequest_RequestMethod_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ILcom_umeng_socialize_net_utils_URequest_RequestMethod_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/StatsRequest", DoNotGenerateAcw=true)]
	internal partial class StatsRequestInvoker : StatsRequest {

		public StatsRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatsRequestInvoker); }
		}

		static IntPtr id_getPath;
		protected override unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
