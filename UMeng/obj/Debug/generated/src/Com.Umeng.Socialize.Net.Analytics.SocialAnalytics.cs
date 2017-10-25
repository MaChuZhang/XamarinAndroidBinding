using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/analytics/SocialAnalytics", DoNotGenerateAcw=true)]
	public sealed partial class SocialAnalytics : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/analytics/SocialAnalytics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocialAnalytics); }
		}

		internal SocialAnalytics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/constructor[@name='SocialAnalytics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocialAnalytics ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocialAnalytics)) {
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

		static IntPtr id_authendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='authendt' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("authendt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Authendt (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			if (id_authendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_authendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "authendt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_authendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_authstart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='authstart' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register ("authstart", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/String;ZLjava/lang/String;)V", "")]
		public static unsafe void Authstart (global::Android.Content.Context p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, string p2, bool p3, string p4)
		{
			if (id_authstart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZLjava_lang_String_ == IntPtr.Zero)
				id_authstart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "authstart", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/String;ZLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_authstart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_dauStats_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='dauStats' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("dauStats", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void DauStats (global::Android.Content.Context p0, bool p1)
		{
			if (id_dauStats_Landroid_content_Context_Z == IntPtr.Zero)
				id_dauStats_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "dauStats", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dauStats_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_getInfoendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='getInfoendt' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getInfoendt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetInfoendt (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			if (id_getInfoendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInfoendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInfoendt", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getInfoendt_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getInfostart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='getInfostart' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getInfostart", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetInfostart (global::Android.Content.Context p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, string p2, string p3)
		{
			if (id_getInfostart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInfostart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInfostart", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getInfostart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_log_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMediaObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='log' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.umeng.socialize.media.UMediaObject']]"
		[Register ("log", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/umeng/socialize/media/UMediaObject;)V", "")]
		public static unsafe void Log (global::Android.Content.Context p0, string p1, string p2, global::Com.Umeng.Socialize.Media.IUMediaObject p3)
		{
			if (id_log_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMediaObject_ == IntPtr.Zero)
				id_log_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMediaObject_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/umeng/socialize/media/UMediaObject;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMediaObject_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_shareBoardStats_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='shareBoardStats' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("shareBoardStats", "(Landroid/content/Context;)V", "")]
		public static unsafe void ShareBoardStats (global::Android.Content.Context p0)
		{
			if (id_shareBoardStats_Landroid_content_Context_ == IntPtr.Zero)
				id_shareBoardStats_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "shareBoardStats", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shareBoardStats_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_shareend_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='shareend' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("shareend", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Shareend (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			if (id_shareend_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_shareend_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "shareend", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shareend_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_sharestart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZILjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.analytics']/class[@name='SocialAnalytics']/method[@name='sharestart' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='boolean']]"
		[Register ("sharestart", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/String;ZILjava/lang/String;Z)V", "")]
		public static unsafe void Sharestart (global::Android.Content.Context p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, string p2, bool p3, int p4, string p5, bool p6)
		{
			if (id_sharestart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZILjava_lang_String_Z == IntPtr.Zero)
				id_sharestart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZILjava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "sharestart", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/String;ZILjava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sharestart_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_String_ZILjava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

	}
}
