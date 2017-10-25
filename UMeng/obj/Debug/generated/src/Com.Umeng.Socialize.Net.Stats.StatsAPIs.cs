using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/stats/StatsAPIs", DoNotGenerateAcw=true)]
	public partial class StatsAPIs : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/stats/StatsAPIs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatsAPIs); }
		}

		protected StatsAPIs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/constructor[@name='StatsAPIs' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatsAPIs ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatsAPIs)) {
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

		static IntPtr id_authStatsEnd_Lcom_umeng_socialize_net_stats_AuthStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='authStatsEnd' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.AuthStatsRequest']]"
		[Register ("authStatsEnd", "(Lcom/umeng/socialize/net/stats/AuthStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse AuthStatsEnd (global::Com.Umeng.Socialize.Net.Stats.AuthStatsRequest p0)
		{
			if (id_authStatsEnd_Lcom_umeng_socialize_net_stats_AuthStatsRequest_ == IntPtr.Zero)
				id_authStatsEnd_Lcom_umeng_socialize_net_stats_AuthStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "authStatsEnd", "(Lcom/umeng/socialize/net/stats/AuthStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_authStatsEnd_Lcom_umeng_socialize_net_stats_AuthStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_authStatsStart_Lcom_umeng_socialize_net_stats_AuthStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='authStatsStart' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.AuthStatsRequest']]"
		[Register ("authStatsStart", "(Lcom/umeng/socialize/net/stats/AuthStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse AuthStatsStart (global::Com.Umeng.Socialize.Net.Stats.AuthStatsRequest p0)
		{
			if (id_authStatsStart_Lcom_umeng_socialize_net_stats_AuthStatsRequest_ == IntPtr.Zero)
				id_authStatsStart_Lcom_umeng_socialize_net_stats_AuthStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "authStatsStart", "(Lcom/umeng/socialize/net/stats/AuthStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_authStatsStart_Lcom_umeng_socialize_net_stats_AuthStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dauStats_Lcom_umeng_socialize_net_stats_DauStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='dauStats' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.DauStatsRequest']]"
		[Register ("dauStats", "(Lcom/umeng/socialize/net/stats/DauStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse DauStats (global::Com.Umeng.Socialize.Net.Stats.DauStatsRequest p0)
		{
			if (id_dauStats_Lcom_umeng_socialize_net_stats_DauStatsRequest_ == IntPtr.Zero)
				id_dauStats_Lcom_umeng_socialize_net_stats_DauStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "dauStats", "(Lcom/umeng/socialize/net/stats/DauStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dauStats_Lcom_umeng_socialize_net_stats_DauStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shareStatsEnd_Lcom_umeng_socialize_net_stats_ShareStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='shareStatsEnd' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.ShareStatsRequest']]"
		[Register ("shareStatsEnd", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse ShareStatsEnd (global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest p0)
		{
			if (id_shareStatsEnd_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ == IntPtr.Zero)
				id_shareStatsEnd_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "shareStatsEnd", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shareStatsEnd_Lcom_umeng_socialize_net_stats_ShareStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shareStatsStart_Lcom_umeng_socialize_net_stats_ShareStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='shareStatsStart' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.ShareStatsRequest']]"
		[Register ("shareStatsStart", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse ShareStatsStart (global::Com.Umeng.Socialize.Net.Stats.ShareStatsRequest p0)
		{
			if (id_shareStatsStart_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ == IntPtr.Zero)
				id_shareStatsStart_Lcom_umeng_socialize_net_stats_ShareStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "shareStatsStart", "(Lcom/umeng/socialize/net/stats/ShareStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shareStatsStart_Lcom_umeng_socialize_net_stats_ShareStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shareboardStats_Lcom_umeng_socialize_net_stats_StatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='shareboardStats' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.StatsRequest']]"
		[Register ("shareboardStats", "(Lcom/umeng/socialize/net/stats/StatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse ShareboardStats (global::Com.Umeng.Socialize.Net.Stats.StatsRequest p0)
		{
			if (id_shareboardStats_Lcom_umeng_socialize_net_stats_StatsRequest_ == IntPtr.Zero)
				id_shareboardStats_Lcom_umeng_socialize_net_stats_StatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "shareboardStats", "(Lcom/umeng/socialize/net/stats/StatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shareboardStats_Lcom_umeng_socialize_net_stats_StatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_userInfoStatsEnd_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='userInfoStatsEnd' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.UserInfoStatsRequest']]"
		[Register ("userInfoStatsEnd", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse UserInfoStatsEnd (global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest p0)
		{
			if (id_userInfoStatsEnd_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_ == IntPtr.Zero)
				id_userInfoStatsEnd_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "userInfoStatsEnd", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_userInfoStatsEnd_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_userInfoStatsStart_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.stats']/class[@name='StatsAPIs']/method[@name='userInfoStatsStart' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.stats.UserInfoStatsRequest']]"
		[Register ("userInfoStatsStart", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse UserInfoStatsStart (global::Com.Umeng.Socialize.Net.Stats.UserInfoStatsRequest p0)
		{
			if (id_userInfoStatsStart_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_ == IntPtr.Zero)
				id_userInfoStatsStart_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_ = JNIEnv.GetStaticMethodID (class_ref, "userInfoStatsStart", "(Lcom/umeng/socialize/net/stats/UserInfoStatsRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_userInfoStatsStart_Lcom_umeng_socialize_net_stats_UserInfoStatsRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
