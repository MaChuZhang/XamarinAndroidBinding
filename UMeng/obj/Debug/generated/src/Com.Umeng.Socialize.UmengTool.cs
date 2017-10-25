using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']"
	[global::Android.Runtime.Register ("com/umeng/socialize/UmengTool", DoNotGenerateAcw=true)]
	public partial class UmengTool : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/UmengTool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengTool); }
		}

		protected UmengTool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/constructor[@name='UmengTool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UmengTool ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UmengTool)) {
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

		static IntPtr id_getStrRedicrectUrl;
		public static unsafe string StrRedicrectUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='getStrRedicrectUrl' and count(parameter)=0]"
			[Register ("getStrRedicrectUrl", "()Ljava/lang/String;", "GetGetStrRedicrectUrlHandler")]
			get {
				if (id_getStrRedicrectUrl == IntPtr.Zero)
					id_getStrRedicrectUrl = JNIEnv.GetStaticMethodID (class_ref, "getStrRedicrectUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStrRedicrectUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkAlipay_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkAlipay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkAlipay", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckAlipay (global::Android.Content.Context p0)
		{
			if (id_checkAlipay_Landroid_content_Context_ == IntPtr.Zero)
				id_checkAlipay_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkAlipay", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkAlipay_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkFBByself_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkFBByself' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkFBByself", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckFBByself (global::Android.Content.Context p0)
		{
			if (id_checkFBByself_Landroid_content_Context_ == IntPtr.Zero)
				id_checkFBByself_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkFBByself", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkFBByself_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkFacebook_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkFacebook' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkFacebook", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckFacebook (global::Android.Content.Context p0)
		{
			if (id_checkFacebook_Landroid_content_Context_ == IntPtr.Zero)
				id_checkFacebook_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkFacebook", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkFacebook_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkKakao_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkKakao' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkKakao", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckKakao (global::Android.Content.Context p0)
		{
			if (id_checkKakao_Landroid_content_Context_ == IntPtr.Zero)
				id_checkKakao_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkKakao", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkKakao_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkLinkin_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkLinkin' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkLinkin", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckLinkin (global::Android.Content.Context p0)
		{
			if (id_checkLinkin_Landroid_content_Context_ == IntPtr.Zero)
				id_checkLinkin_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkLinkin", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkLinkin_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkQQ_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkQQ' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkQQ", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckQQ (global::Android.Content.Context p0)
		{
			if (id_checkQQ_Landroid_content_Context_ == IntPtr.Zero)
				id_checkQQ_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkQQ", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkQQ_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkQQByself_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkQQByself' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkQQByself", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckQQByself (global::Android.Content.Context p0)
		{
			if (id_checkQQByself_Landroid_content_Context_ == IntPtr.Zero)
				id_checkQQByself_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkQQByself", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkQQByself_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkSina_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkSina' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkSina", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckSina (global::Android.Content.Context p0)
		{
			if (id_checkSina_Landroid_content_Context_ == IntPtr.Zero)
				id_checkSina_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkSina", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkSina_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkSinaBySelf_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkSinaBySelf' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkSinaBySelf", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckSinaBySelf (global::Android.Content.Context p0)
		{
			if (id_checkSinaBySelf_Landroid_content_Context_ == IntPtr.Zero)
				id_checkSinaBySelf_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkSinaBySelf", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkSinaBySelf_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkVK_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkVK' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkVK", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckVK (global::Android.Content.Context p0)
		{
			if (id_checkVK_Landroid_content_Context_ == IntPtr.Zero)
				id_checkVK_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkVK", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkVK_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkVKByself_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkVKByself' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkVKByself", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckVKByself (global::Android.Content.Context p0)
		{
			if (id_checkVKByself_Landroid_content_Context_ == IntPtr.Zero)
				id_checkVKByself_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkVKByself", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkVKByself_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkWx_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkWx' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkWx", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckWx (global::Android.Content.Context p0)
		{
			if (id_checkWx_Landroid_content_Context_ == IntPtr.Zero)
				id_checkWx_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkWx", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkWx_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkWxBySelf_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='checkWxBySelf' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkWxBySelf", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string CheckWxBySelf (global::Android.Content.Context p0)
		{
			if (id_checkWxBySelf_Landroid_content_Context_ == IntPtr.Zero)
				id_checkWxBySelf_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkWxBySelf", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkWxBySelf_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCertificateSHA1Fingerprint_Landroid_content_pm_PackageInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='getCertificateSHA1Fingerprint' and count(parameter)=1 and parameter[1][@type='android.content.pm.PackageInfo']]"
		[Register ("getCertificateSHA1Fingerprint", "(Landroid/content/pm/PackageInfo;)Ljava/lang/String;", "")]
		public static unsafe string GetCertificateSHA1Fingerprint (global::Android.Content.PM.PackageInfo p0)
		{
			if (id_getCertificateSHA1Fingerprint_Landroid_content_pm_PackageInfo_ == IntPtr.Zero)
				id_getCertificateSHA1Fingerprint_Landroid_content_pm_PackageInfo_ = JNIEnv.GetStaticMethodID (class_ref, "getCertificateSHA1Fingerprint", "(Landroid/content/pm/PackageInfo;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCertificateSHA1Fingerprint_Landroid_content_pm_PackageInfo_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getREDICRECT_URL_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='getREDICRECT_URL' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getREDICRECT_URL", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetREDICRECT_URL (global::Android.Content.Context p0)
		{
			if (id_getREDICRECT_URL_Landroid_content_Context_ == IntPtr.Zero)
				id_getREDICRECT_URL_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getREDICRECT_URL", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getREDICRECT_URL_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getSignature_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='getSignature' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSignature", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetSignature (global::Android.Content.Context p0)
		{
			if (id_getSignature_Landroid_content_Context_ == IntPtr.Zero)
				id_getSignature_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSignature", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getSignature_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getSignatureDigest_Landroid_content_pm_PackageInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='getSignatureDigest' and count(parameter)=1 and parameter[1][@type='android.content.pm.PackageInfo']]"
		[Register ("getSignatureDigest", "(Landroid/content/pm/PackageInfo;)Ljava/lang/String;", "")]
		public static unsafe string GetSignatureDigest (global::Android.Content.PM.PackageInfo p0)
		{
			if (id_getSignatureDigest_Landroid_content_pm_PackageInfo_ == IntPtr.Zero)
				id_getSignatureDigest_Landroid_content_pm_PackageInfo_ = JNIEnv.GetStaticMethodID (class_ref, "getSignatureDigest", "(Landroid/content/pm/PackageInfo;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSignatureDigest_Landroid_content_pm_PackageInfo_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_showDialog_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='showDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("showDialog", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ShowDialog (global::Android.Content.Context p0, string p1)
		{
			if (id_showDialog_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_showDialog_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showDialog", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showDialog_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_showDialogWithURl_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UmengTool']/method[@name='showDialogWithURl' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showDialogWithURl", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void ShowDialogWithURl (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_showDialogWithURl_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showDialogWithURl_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showDialogWithURl", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showDialogWithURl_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
