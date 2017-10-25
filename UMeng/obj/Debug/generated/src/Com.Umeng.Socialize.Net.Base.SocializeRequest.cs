using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/base/SocializeRequest", DoNotGenerateAcw=true)]
	public abstract partial class SocializeRequest : global::Com.Umeng.Socialize.Net.Utils.URequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/field[@name='REQUEST_ANALYTIC']"
		[Register ("REQUEST_ANALYTIC")]
		public const int RequestAnalytic = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/field[@name='REQUEST_API']"
		[Register ("REQUEST_API")]
		public const int RequestApi = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/field[@name='REQUEST_SOCIAL']"
		[Register ("REQUEST_SOCIAL")]
		public const int RequestSocial = (int) 0;

		static IntPtr mOpId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/field[@name='mOpId']"
		[Register ("mOpId")]
		public int MOpId {
			get {
				if (mOpId_jfieldId == IntPtr.Zero)
					mOpId_jfieldId = JNIEnv.GetFieldID (class_ref, "mOpId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mOpId_jfieldId);
			}
			set {
				if (mOpId_jfieldId == IntPtr.Zero)
					mOpId_jfieldId = JNIEnv.GetFieldID (class_ref, "mOpId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOpId_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest.FILE_TYPE']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/base/SocializeRequest$FILE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class FILE_TYPE : global::Java.Lang.Enum {


			static IntPtr IMAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest.FILE_TYPE']/field[@name='IMAGE']"
			[Register ("IMAGE")]
			public static global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE Image {
				get {
					if (IMAGE_jfieldId == IntPtr.Zero)
						IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE", "Lcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VEDIO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest.FILE_TYPE']/field[@name='VEDIO']"
			[Register ("VEDIO")]
			public static global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE Vedio {
				get {
					if (VEDIO_jfieldId == IntPtr.Zero)
						VEDIO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VEDIO", "Lcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VEDIO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/base/SocializeRequest$FILE_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FILE_TYPE); }
			}

			internal FILE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest.FILE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest.FILE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;");
				try {
					return (global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/base/SocializeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeRequest); }
		}

		protected SocializeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ILcom_umeng_socialize_net_utils_URequest_RequestMethod_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/constructor[@name='SocializeRequest' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;? extends com.umeng.socialize.net.base.SocializeReseponse&gt;'] and parameter[4][@type='int'] and parameter[5][@type='com.umeng.socialize.net.utils.URequest.RequestMethod']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;ILcom/umeng/socialize/net/utils/URequest$RequestMethod;)V", "")]
		public unsafe SocializeRequest (global::Android.Content.Context p0, string p1, global::Java.Lang.Class p2, int p3, global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod p4)
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
				if (GetType () != typeof (SocializeRequest)) {
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
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		protected abstract string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")] get;
		}

		static Delegate cb_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_Handler ()
		{
			if (cb_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_ == null)
				cb_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_);
			return cb_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_;
		}

		static void n_AddFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddFileParams (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='addFileParams' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.umeng.socialize.net.base.SocializeRequest.FILE_TYPE'] and parameter[3][@type='java.lang.String']]"
		[Register ("addFileParams", "([BLcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;Ljava/lang/String;)V", "GetAddFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_Handler")]
		public virtual unsafe void AddFileParams (byte[] p0, global::Com.Umeng.Socialize.Net.Base.SocializeRequest.FILE_TYPE p1, string p2)
		{
			if (id_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_ == IntPtr.Zero)
				id_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addFileParams", "([BLcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFileParams_arrayBLcom_umeng_socialize_net_base_SocializeRequest_FILE_TYPE_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFileParams", "([BLcom/umeng/socialize/net/base/SocializeRequest$FILE_TYPE;Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_;
#pragma warning disable 0169
		static Delegate GetAddMediaParams_Lcom_umeng_socialize_media_UMediaObject_Handler ()
		{
			if (cb_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_ == null)
				cb_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMediaParams_Lcom_umeng_socialize_media_UMediaObject_);
			return cb_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_;
		}

		static void n_AddMediaParams_Lcom_umeng_socialize_media_UMediaObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.IUMediaObject p0 = (global::Com.Umeng.Socialize.Media.IUMediaObject)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMediaParams (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='addMediaParams' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMediaObject']]"
		[Register ("addMediaParams", "(Lcom/umeng/socialize/media/UMediaObject;)V", "GetAddMediaParams_Lcom_umeng_socialize_media_UMediaObject_Handler")]
		public virtual unsafe void AddMediaParams (global::Com.Umeng.Socialize.Media.IUMediaObject p0)
		{
			if (id_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_ == IntPtr.Zero)
				id_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_ = JNIEnv.GetMethodID (class_ref, "addMediaParams", "(Lcom/umeng/socialize/media/UMediaObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMediaParams_Lcom_umeng_socialize_media_UMediaObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMediaParams", "(Lcom/umeng/socialize/media/UMediaObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_buildParams;
#pragma warning disable 0169
		static Delegate GetBuildParamsHandler ()
		{
			if (cb_buildParams == null)
				cb_buildParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildParams);
			return cb_buildParams;
		}

		static IntPtr n_BuildParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.BuildParams ());
		}
#pragma warning restore 0169

		static IntPtr id_buildParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='buildParams' and count(parameter)=0]"
		[Register ("buildParams", "()Ljava/util/Map;", "GetBuildParamsHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> BuildParams ()
		{
			if (id_buildParams == IntPtr.Zero)
				id_buildParams = JNIEnv.GetMethodID (class_ref, "buildParams", "()Ljava/util/Map;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getBaseQuery_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='getBaseQuery' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBaseQuery", "(Landroid/content/Context;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBaseQuery (global::Android.Content.Context p0)
		{
			if (id_getBaseQuery_Landroid_content_Context_ == IntPtr.Zero)
				id_getBaseQuery_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getBaseQuery", "(Landroid/content/Context;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBaseQuery_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setReqType_I;
#pragma warning disable 0169
		static Delegate GetSetReqType_IHandler ()
		{
			if (cb_setReqType_I == null)
				cb_setReqType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReqType_I);
			return cb_setReqType_I;
		}

		static void n_SetReqType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReqType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReqType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='setReqType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReqType", "(I)V", "GetSetReqType_IHandler")]
		public virtual unsafe void SetReqType (int p0)
		{
			if (id_setReqType_I == IntPtr.Zero)
				id_setReqType_I = JNIEnv.GetMethodID (class_ref, "setReqType", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReqType_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReqType", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toGetUrl;
#pragma warning disable 0169
		static Delegate GetToGetUrlHandler ()
		{
			if (cb_toGetUrl == null)
				cb_toGetUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToGetUrl);
			return cb_toGetUrl;
		}

		static IntPtr n_ToGetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToGetUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_toGetUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='toGetUrl' and count(parameter)=0]"
		[Register ("toGetUrl", "()Ljava/lang/String;", "GetToGetUrlHandler")]
		public override unsafe string ToGetUrl ()
		{
			if (id_toGetUrl == IntPtr.Zero)
				id_toGetUrl = JNIEnv.GetMethodID (class_ref, "toGetUrl", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toGetUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toGetUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeRequest']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public override unsafe global::Org.Json.JSONObject ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Lorg/json/JSONObject;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/net/base/SocializeRequest", DoNotGenerateAcw=true)]
	internal partial class SocializeRequestInvoker : SocializeRequest {

		public SocializeRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeRequestInvoker); }
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
