using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/Log", DoNotGenerateAcw=true)]
	public partial class Log : global::Java.Lang.Object {


		static IntPtr Logs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/field[@name='Logs']"
		[Register ("Logs")]
		public static bool Logs {
			get {
				if (Logs_jfieldId == IntPtr.Zero)
					Logs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Logs", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, Logs_jfieldId);
			}
			set {
				if (Logs_jfieldId == IntPtr.Zero)
					Logs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Logs", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, Logs_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		public const string Logtag = (string) "6.4.5umeng_tool----";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/field[@name='NETTAG']"
		[Register ("NETTAG")]
		public const string Nettag = (string) "6.4.5net_test----";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "umengsocial";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/Log", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Log); }
		}

		protected Log (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/constructor[@name='Log' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Log ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Log)) {
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

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void D (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void E (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0, string p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void I (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_net_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='net' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("net", "(Ljava/lang/String;)V", "")]
		public static unsafe void Net (string p0)
		{
			if (id_net_Ljava_lang_String_ == IntPtr.Zero)
				id_net_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "net", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_net_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toast_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='toast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("toast", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Toast (global::Android.Content.Context p0, string p1)
		{
			if (id_toast_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_toast_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toast", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_toast_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_um_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='um' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("um", "(Ljava/lang/String;)V", "")]
		public static unsafe void Um (string p0)
		{
			if (id_um_Ljava_lang_String_ == IntPtr.Zero)
				id_um_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "um", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_um_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_umd_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='umd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("umd", "(Ljava/lang/String;)V", "")]
		public static unsafe void Umd (string p0)
		{
			if (id_umd_Ljava_lang_String_ == IntPtr.Zero)
				id_umd_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "umd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_umd_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_url_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='url' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("url", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Url (string p0, string p1)
		{
			if (id_url_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_url_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "url", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_url_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_url_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='url' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("url", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Url (string p0, string p1, string p2)
		{
			if (id_url_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_url_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "url", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_url_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "")]
		public static unsafe void V (string p0)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void V (string p0, string p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void V (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "")]
		public static unsafe void W (string p0)
		{
			if (id_w_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string p0, string p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void W (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_y_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='Log']/method[@name='y' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("y", "(Ljava/lang/String;)V", "")]
		public static unsafe void Y (string p0)
		{
			if (id_y_Ljava_lang_String_ == IntPtr.Zero)
				id_y_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "y", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_y_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
