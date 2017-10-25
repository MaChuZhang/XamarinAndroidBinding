using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/SocializeUtils", DoNotGenerateAcw=true)]
	public partial class SocializeUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "SocializeUtils";

		static IntPtr deleteUris_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/field[@name='deleteUris']"
		[Register ("deleteUris")]
		public static global::System.Collections.ICollection DeleteUris {
			get {
				if (deleteUris_jfieldId == IntPtr.Zero)
					deleteUris_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "deleteUris", "Ljava/util/Set;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, deleteUris_jfieldId);
				return global::Android.Runtime.JavaSet.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (deleteUris_jfieldId == IntPtr.Zero)
					deleteUris_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "deleteUris", "Ljava/util/Set;");
				IntPtr native_value = global::Android.Runtime.JavaSet.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, deleteUris_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/SocializeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeUtils); }
		}

		protected SocializeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/constructor[@name='SocializeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializeUtils)) {
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

		static IntPtr id_File2byte_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='File2byte' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("File2byte", "(Ljava/io/File;)[B", "")]
		public static unsafe byte[] File2byte (global::Java.IO.File p0)
		{
			if (id_File2byte_Ljava_io_File_ == IntPtr.Zero)
				id_File2byte_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "File2byte", "(Ljava/io/File;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_File2byte_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertBinaryInvalid_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='assertBinaryInvalid' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("assertBinaryInvalid", "([B)Z", "")]
		public static unsafe bool AssertBinaryInvalid (byte[] p0)
		{
			if (id_assertBinaryInvalid_arrayB == IntPtr.Zero)
				id_assertBinaryInvalid_arrayB = JNIEnv.GetStaticMethodID (class_ref, "assertBinaryInvalid", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_assertBinaryInvalid_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_bundleTomap_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='bundleTomap' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("bundleTomap", "(Landroid/os/Bundle;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> BundleTomap (global::Android.OS.Bundle p0)
		{
			if (id_bundleTomap_Landroid_os_Bundle_ == IntPtr.Zero)
				id_bundleTomap_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "bundleTomap", "(Landroid/os/Bundle;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_bundleTomap_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_countContentLength_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='countContentLength' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("countContentLength", "(Ljava/lang/String;)I", "")]
		public static unsafe int CountContentLength (string p0)
		{
			if (id_countContentLength_Ljava_lang_String_ == IntPtr.Zero)
				id_countContentLength_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "countContentLength", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_countContentLength_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='decodeUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle DecodeUrl (string p0)
		{
			if (id_decodeUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dip2Px_Landroid_content_Context_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='dip2Px' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("dip2Px", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Dip2Px (global::Android.Content.Context p0, float p1)
		{
			if (id_dip2Px_Landroid_content_Context_F == IntPtr.Zero)
				id_dip2Px_Landroid_content_Context_F = JNIEnv.GetStaticMethodID (class_ref, "dip2Px", "(Landroid/content/Context;F)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_dip2Px_Landroid_content_Context_F, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAppkey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='getAppkey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppkey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppkey (global::Android.Content.Context p0)
		{
			if (id_getAppkey_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppkey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppkey", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppkey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFloatWindowSize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='getFloatWindowSize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getFloatWindowSize", "(Landroid/content/Context;)[I", "")]
		public static unsafe int[] GetFloatWindowSize (global::Android.Content.Context p0)
		{
			if (id_getFloatWindowSize_Landroid_content_Context_ == IntPtr.Zero)
				id_getFloatWindowSize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getFloatWindowSize", "(Landroid/content/Context;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFloatWindowSize_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_insertImage_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='insertImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("insertImage", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri InsertImage (global::Android.Content.Context p0, string p1)
		{
			if (id_insertImage_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_insertImage_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "insertImage", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_insertImage_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isFloatWindowStyle_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='isFloatWindowStyle' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isFloatWindowStyle", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsFloatWindowStyle (global::Android.Content.Context p0)
		{
			if (id_isFloatWindowStyle_Landroid_content_Context_ == IntPtr.Zero)
				id_isFloatWindowStyle_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isFloatWindowStyle", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFloatWindowStyle_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isToday_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='isToday' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isToday", "(J)Z", "")]
		public static unsafe bool IsToday (long p0)
		{
			if (id_isToday_J == IntPtr.Zero)
				id_isToday_J = JNIEnv.GetStaticMethodID (class_ref, "isToday", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isToday_J, __args);
			} finally {
			}
		}

		static IntPtr id_jsonToMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='jsonToMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonToMap", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> JsonToMap (string p0)
		{
			if (id_jsonToMap_Ljava_lang_String_ == IntPtr.Zero)
				id_jsonToMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "jsonToMap", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonToMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_mapToBundle_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='mapToBundle' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("mapToBundle", "(Ljava/util/Map;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle MapToBundle (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_mapToBundle_Ljava_util_Map_ == IntPtr.Zero)
				id_mapToBundle_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "mapToBundle", "(Ljava/util/Map;)Landroid/os/Bundle;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mapToBundle_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_openApplicationMarket_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='openApplicationMarket' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("openApplicationMarket", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OpenApplicationMarket (global::Android.Content.Context p0, string p1)
		{
			if (id_openApplicationMarket_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_openApplicationMarket_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "openApplicationMarket", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openApplicationMarket_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_parseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='parseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ParseUrl (string p0)
		{
			if (id_parseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_safeCloseDialog_Landroid_app_Dialog_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='safeCloseDialog' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Register ("safeCloseDialog", "(Landroid/app/Dialog;)V", "")]
		public static unsafe void SafeCloseDialog (global::Android.App.Dialog p0)
		{
			if (id_safeCloseDialog_Landroid_app_Dialog_ == IntPtr.Zero)
				id_safeCloseDialog_Landroid_app_Dialog_ = JNIEnv.GetStaticMethodID (class_ref, "safeCloseDialog", "(Landroid/app/Dialog;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_safeCloseDialog_Landroid_app_Dialog_, __args);
			} finally {
			}
		}

		static IntPtr id_safeShowDialog_Landroid_app_Dialog_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeUtils']/method[@name='safeShowDialog' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Register ("safeShowDialog", "(Landroid/app/Dialog;)V", "")]
		public static unsafe void SafeShowDialog (global::Android.App.Dialog p0)
		{
			if (id_safeShowDialog_Landroid_app_Dialog_ == IntPtr.Zero)
				id_safeShowDialog_Landroid_app_Dialog_ = JNIEnv.GetStaticMethodID (class_ref, "safeShowDialog", "(Landroid/app/Dialog;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_safeShowDialog_Landroid_app_Dialog_, __args);
			} finally {
			}
		}

	}
}
