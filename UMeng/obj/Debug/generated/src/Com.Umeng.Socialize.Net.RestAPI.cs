using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/RestAPI", DoNotGenerateAcw=true)]
	public partial class RestAPI : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/RestAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RestAPI); }
		}

		protected RestAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']/constructor[@name='RestAPI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RestAPI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RestAPI)) {
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

		static IntPtr id_convertLinkCard_Lcom_umeng_socialize_net_LinkcardRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']/method[@name='convertLinkCard' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.LinkcardRequest']]"
		[Register ("convertLinkCard", "(Lcom/umeng/socialize/net/LinkcardRequest;)Lcom/umeng/socialize/net/LinkCardResponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.LinkCardResponse ConvertLinkCard (global::Com.Umeng.Socialize.Net.LinkcardRequest p0)
		{
			if (id_convertLinkCard_Lcom_umeng_socialize_net_LinkcardRequest_ == IntPtr.Zero)
				id_convertLinkCard_Lcom_umeng_socialize_net_LinkcardRequest_ = JNIEnv.GetStaticMethodID (class_ref, "convertLinkCard", "(Lcom/umeng/socialize/net/LinkcardRequest;)Lcom/umeng/socialize/net/LinkCardResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.LinkCardResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.LinkCardResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertLinkCard_Lcom_umeng_socialize_net_LinkcardRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doShare_Lcom_umeng_socialize_net_SharePostRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']/method[@name='doShare' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.SharePostRequest']]"
		[Register ("doShare", "(Lcom/umeng/socialize/net/SharePostRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse DoShare (global::Com.Umeng.Socialize.Net.SharePostRequest p0)
		{
			if (id_doShare_Lcom_umeng_socialize_net_SharePostRequest_ == IntPtr.Zero)
				id_doShare_Lcom_umeng_socialize_net_SharePostRequest_ = JNIEnv.GetStaticMethodID (class_ref, "doShare", "(Lcom/umeng/socialize/net/SharePostRequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_doShare_Lcom_umeng_socialize_net_SharePostRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_queryShareId_Lcom_umeng_socialize_net_ActionBarRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']/method[@name='queryShareId' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.ActionBarRequest']]"
		[Register ("queryShareId", "(Lcom/umeng/socialize/net/ActionBarRequest;)Lcom/umeng/socialize/net/ActionBarResponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.ActionBarResponse QueryShareId (global::Com.Umeng.Socialize.Net.ActionBarRequest p0)
		{
			if (id_queryShareId_Lcom_umeng_socialize_net_ActionBarRequest_ == IntPtr.Zero)
				id_queryShareId_Lcom_umeng_socialize_net_ActionBarRequest_ = JNIEnv.GetStaticMethodID (class_ref, "queryShareId", "(Lcom/umeng/socialize/net/ActionBarRequest;)Lcom/umeng/socialize/net/ActionBarResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.ActionBarResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.ActionBarResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_queryShareId_Lcom_umeng_socialize_net_ActionBarRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_uploadPlatformToken_Lcom_umeng_socialize_net_PlatformTokenUploadReq_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']/method[@name='uploadPlatformToken' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.PlatformTokenUploadReq']]"
		[Register ("uploadPlatformToken", "(Lcom/umeng/socialize/net/PlatformTokenUploadReq;)Lcom/umeng/socialize/net/PlatformTokenUploadResponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.PlatformTokenUploadResponse UploadPlatformToken (global::Com.Umeng.Socialize.Net.PlatformTokenUploadReq p0)
		{
			if (id_uploadPlatformToken_Lcom_umeng_socialize_net_PlatformTokenUploadReq_ == IntPtr.Zero)
				id_uploadPlatformToken_Lcom_umeng_socialize_net_PlatformTokenUploadReq_ = JNIEnv.GetStaticMethodID (class_ref, "uploadPlatformToken", "(Lcom/umeng/socialize/net/PlatformTokenUploadReq;)Lcom/umeng/socialize/net/PlatformTokenUploadResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.PlatformTokenUploadResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.PlatformTokenUploadResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_uploadPlatformToken_Lcom_umeng_socialize_net_PlatformTokenUploadReq_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_uploadUrl_Lcom_umeng_socialize_net_UrlRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='RestAPI']/method[@name='uploadUrl' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.UrlRequest']]"
		[Register ("uploadUrl", "(Lcom/umeng/socialize/net/UrlRequest;)Lcom/umeng/socialize/net/UrlResponse;", "")]
		public static unsafe global::Com.Umeng.Socialize.Net.UrlResponse UploadUrl (global::Com.Umeng.Socialize.Net.UrlRequest p0)
		{
			if (id_uploadUrl_Lcom_umeng_socialize_net_UrlRequest_ == IntPtr.Zero)
				id_uploadUrl_Lcom_umeng_socialize_net_UrlRequest_ = JNIEnv.GetStaticMethodID (class_ref, "uploadUrl", "(Lcom/umeng/socialize/net/UrlRequest;)Lcom/umeng/socialize/net/UrlResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Net.UrlResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.UrlResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_uploadUrl_Lcom_umeng_socialize_net_UrlRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
