using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']"
	[global::Android.Runtime.Register ("com/umeng/socialize/bean/HandlerRequestCode", DoNotGenerateAcw=true)]
	public sealed partial class HandlerRequestCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='DEFAULT_REQUEST_CODE']"
		[Register ("DEFAULT_REQUEST_CODE")]
		public const int DefaultRequestCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='DOUBAN_REQUEST_CODE']"
		[Register ("DOUBAN_REQUEST_CODE")]
		public const int DoubanRequestCode = (int) 5660;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='DROPBOX_REQUEST_AUTH_CODE']"
		[Register ("DROPBOX_REQUEST_AUTH_CODE")]
		public const int DropboxRequestAuthCode = (int) 67209;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='FACEBOOK_REQUEST_AUTH_CODE']"
		[Register ("FACEBOOK_REQUEST_AUTH_CODE")]
		public const int FacebookRequestAuthCode = (int) 64206;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='FACEBOOK_REQUEST_SHARE_CODE']"
		[Register ("FACEBOOK_REQUEST_SHARE_CODE")]
		public const int FacebookRequestShareCode = (int) 64207;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='FACEBOOK_REQUEST_SHARE_MESSAGE_CODE']"
		[Register ("FACEBOOK_REQUEST_SHARE_MESSAGE_CODE")]
		public const int FacebookRequestShareMessageCode = (int) 64208;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='KAKAO_REQUEST_CODE']"
		[Register ("KAKAO_REQUEST_CODE")]
		public const int KakaoRequestCode = (int) 5670;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='RENREN_REQUEST_CODE']"
		[Register ("RENREN_REQUEST_CODE")]
		public const int RenrenRequestCode = (int) 5661;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='REQUEST_LOGIN']"
		[Register ("REQUEST_LOGIN")]
		public const int RequestLogin = (int) 11101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='REQUEST_QQ_SHARE']"
		[Register ("REQUEST_QQ_SHARE")]
		public const int RequestQqShare = (int) 10103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='REQUEST_QZONE_SHARE']"
		[Register ("REQUEST_QZONE_SHARE")]
		public const int RequestQzoneShare = (int) 10104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='SINASSO_REQUEST_CODE']"
		[Register ("SINASSO_REQUEST_CODE")]
		public const int SinassoRequestCode = (int) 5650;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='SINA_AUTH_REQUEST_CODE']"
		[Register ("SINA_AUTH_REQUEST_CODE")]
		public const int SinaAuthRequestCode = (int) 32973;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='SINA_REQUEST_CODE']"
		[Register ("SINA_REQUEST_CODE")]
		public const int SinaRequestCode = (int) 5659;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='SINA_SHARE_REQUEST_CODE']"
		[Register ("SINA_SHARE_REQUEST_CODE")]
		public const int SinaShareRequestCode = (int) 765;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='TENCENT_WB_REQUEST_CODE']"
		[Register ("TENCENT_WB_REQUEST_CODE")]
		public const int TencentWbRequestCode = (int) 5662;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='TEST_CODE']"
		[Register ("TEST_CODE")]
		public const int TestCode = (int) 888888;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='TWITTER_REQUEST_AUTH_CODE']"
		[Register ("TWITTER_REQUEST_AUTH_CODE")]
		public const int TwitterRequestAuthCode = (int) 64209;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='VK_REQUEST_AUTH_CODE']"
		[Register ("VK_REQUEST_AUTH_CODE")]
		public const int VkRequestAuthCode = (int) 10485;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='WX_CIRCLE_REQUEST_CODE']"
		[Register ("WX_CIRCLE_REQUEST_CODE")]
		public const int WxCircleRequestCode = (int) 10085;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/field[@name='WX_REQUEST_CODE']"
		[Register ("WX_REQUEST_CODE")]
		public const int WxRequestCode = (int) 10086;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/bean/HandlerRequestCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandlerRequestCode); }
		}

		internal HandlerRequestCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='HandlerRequestCode']/constructor[@name='HandlerRequestCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandlerRequestCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HandlerRequestCode)) {
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

	}
}
