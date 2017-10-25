using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/UClient", DoNotGenerateAcw=true)]
	public partial class UClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient.ResponseObj']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/UClient$ResponseObj", DoNotGenerateAcw=true)]
		protected internal partial class ResponseObj : global::Java.Lang.Object {


			static IntPtr httpResponseCode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient.ResponseObj']/field[@name='httpResponseCode']"
			[Register ("httpResponseCode")]
			public int HttpResponseCode {
				get {
					if (httpResponseCode_jfieldId == IntPtr.Zero)
						httpResponseCode_jfieldId = JNIEnv.GetFieldID (class_ref, "httpResponseCode", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, httpResponseCode_jfieldId);
				}
				set {
					if (httpResponseCode_jfieldId == IntPtr.Zero)
						httpResponseCode_jfieldId = JNIEnv.GetFieldID (class_ref, "httpResponseCode", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, httpResponseCode_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr jsonObject_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient.ResponseObj']/field[@name='jsonObject']"
			[Register ("jsonObject")]
			public global::Org.Json.JSONObject JsonObject {
				get {
					if (jsonObject_jfieldId == IntPtr.Zero)
						jsonObject_jfieldId = JNIEnv.GetFieldID (class_ref, "jsonObject", "Lorg/json/JSONObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, jsonObject_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (jsonObject_jfieldId == IntPtr.Zero)
						jsonObject_jfieldId = JNIEnv.GetFieldID (class_ref, "jsonObject", "Lorg/json/JSONObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, jsonObject_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/utils/UClient$ResponseObj", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResponseObj); }
			}

			protected ResponseObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient.ResponseObj']/constructor[@name='UClient.ResponseObj' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe ResponseObj ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ResponseObj)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/UClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UClient); }
		}

		protected UClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/constructor[@name='UClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UClient)) {
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

		static Delegate cb_closeQuietly_Ljava_io_Closeable_;
#pragma warning disable 0169
		static Delegate GetCloseQuietly_Ljava_io_Closeable_Handler ()
		{
			if (cb_closeQuietly_Ljava_io_Closeable_ == null)
				cb_closeQuietly_Ljava_io_Closeable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CloseQuietly_Ljava_io_Closeable_);
			return cb_closeQuietly_Ljava_io_Closeable_;
		}

		static void n_CloseQuietly_Ljava_io_Closeable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.UClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.ICloseable p0 = (global::Java.IO.ICloseable)global::Java.Lang.Object.GetObject<global::Java.IO.ICloseable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CloseQuietly (p0);
		}
#pragma warning restore 0169

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "GetCloseQuietly_Ljava_io_Closeable_Handler")]
		protected virtual unsafe void CloseQuietly (global::Java.IO.ICloseable p0)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeQuietly_Ljava_io_Closeable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeQuietly", "(Ljava/io/Closeable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_convertStreamToString_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetConvertStreamToString_Ljava_io_InputStream_Handler ()
		{
			if (cb_convertStreamToString_Ljava_io_InputStream_ == null)
				cb_convertStreamToString_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConvertStreamToString_Ljava_io_InputStream_);
			return cb_convertStreamToString_Ljava_io_InputStream_;
		}

		static IntPtr n_ConvertStreamToString_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.UClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ConvertStreamToString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/method[@name='convertStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "GetConvertStreamToString_Ljava_io_InputStream_Handler")]
		protected virtual unsafe string ConvertStreamToString (global::System.IO.Stream p0)
		{
			if (id_convertStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_convertStreamToString_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertStreamToString_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCreateResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_Handler ()
		{
			if (cb_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_ == null)
				cb_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_);
			return cb_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_;
		}

		static IntPtr n_CreateResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.UClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Net.Utils.UClient.ResponseObj p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient.ResponseObj> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/method[@name='createResponse' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.net.utils.UClient.ResponseObj'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("createResponse", "(Lcom/umeng/socialize/net/utils/UClient$ResponseObj;Ljava/lang/Class;)Lcom/umeng/socialize/net/utils/UResponse;", "GetCreateResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.umeng.socialize.net.utils.UResponse"})]
		protected virtual unsafe global::Java.Lang.Object CreateResponse (global::Com.Umeng.Socialize.Net.Utils.UClient.ResponseObj p0, global::Java.Lang.Class p1)
		{
			if (id_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_ == IntPtr.Zero)
				id_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "createResponse", "(Lcom/umeng/socialize/net/utils/UClient$ResponseObj;Ljava/lang/Class;)Lcom/umeng/socialize/net/utils/UResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createResponse_Lcom_umeng_socialize_net_utils_UClient_ResponseObj_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createResponse", "(Lcom/umeng/socialize/net/utils/UClient$ResponseObj;Ljava/lang/Class;)Lcom/umeng/socialize/net/utils/UResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_Handler ()
		{
			if (cb_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_ == null)
				cb_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_);
			return cb_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_;
		}

		static IntPtr n_Execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.UClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Net.Utils.URequest p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.net.utils.URequest'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("execute", "(Lcom/umeng/socialize/net/utils/URequest;Ljava/lang/Class;)Lcom/umeng/socialize/net/utils/UResponse;", "GetExecute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.umeng.socialize.net.utils.UResponse"})]
		public virtual unsafe global::Java.Lang.Object Execute (global::Com.Umeng.Socialize.Net.Utils.URequest p0, global::Java.Lang.Class p1)
		{
			if (id_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_ == IntPtr.Zero)
				id_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/umeng/socialize/net/utils/URequest;Ljava/lang/Class;)Lcom/umeng/socialize/net/utils/UResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lcom/umeng/socialize/net/utils/URequest;Ljava/lang/Class;)Lcom/umeng/socialize/net/utils/UResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Handler ()
		{
			if (cb_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ == null)
				cb_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_);
			return cb_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_;
		}

		static IntPtr n_ParseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Umeng.Socialize.Net.Utils.UClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Net.Utils.URequest p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p3 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseResult (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/method[@name='parseResult' and count(parameter)=4 and parameter[1][@type='com.umeng.socialize.net.utils.URequest'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.io.InputStream']]"
		[Register ("parseResult", "(Lcom/umeng/socialize/net/utils/URequest;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)Lorg/json/JSONObject;", "GetParseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Handler")]
		protected virtual unsafe global::Org.Json.JSONObject ParseResult (global::Com.Umeng.Socialize.Net.Utils.URequest p0, string p1, string p2, global::System.IO.Stream p3)
		{
			if (id_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "parseResult", "(Lcom/umeng/socialize/net/utils/URequest;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseResult_Lcom_umeng_socialize_net_utils_URequest_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseResult", "(Lcom/umeng/socialize/net/utils/URequest;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_wrapStream_Ljava_lang_String_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetWrapStream_Ljava_lang_String_Ljava_io_InputStream_Handler ()
		{
			if (cb_wrapStream_Ljava_lang_String_Ljava_io_InputStream_ == null)
				cb_wrapStream_Ljava_lang_String_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WrapStream_Ljava_lang_String_Ljava_io_InputStream_);
			return cb_wrapStream_Ljava_lang_String_Ljava_io_InputStream_;
		}

		static IntPtr n_WrapStream_Ljava_lang_String_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.UClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.UClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.WrapStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrapStream_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='UClient']/method[@name='wrapStream' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("wrapStream", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/io/InputStream;", "GetWrapStream_Ljava_lang_String_Ljava_io_InputStream_Handler")]
		protected virtual unsafe global::System.IO.Stream WrapStream (string p0, global::System.IO.Stream p1)
		{
			if (id_wrapStream_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_wrapStream_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "wrapStream", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_wrapStream_Ljava_lang_String_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrapStream", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
