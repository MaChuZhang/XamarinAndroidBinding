using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Params {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/params/WeiboParameters", DoNotGenerateAcw=true)]
	public partial class WeiboParameters : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/params/WeiboParameters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeiboParameters); }
		}

		protected WeiboParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/constructor[@name='WeiboParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe WeiboParameters (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (WeiboParameters)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static IntPtr id_getAppKey;
		public virtual unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasBinaryData;
#pragma warning disable 0169
		static Delegate GetHasBinaryDataHandler ()
		{
			if (cb_hasBinaryData == null)
				cb_hasBinaryData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBinaryData);
			return cb_hasBinaryData;
		}

		static bool n_HasBinaryData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBinaryData;
		}
#pragma warning restore 0169

		static IntPtr id_hasBinaryData;
		public virtual unsafe bool HasBinaryData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='hasBinaryData' and count(parameter)=0]"
			[Register ("hasBinaryData", "()Z", "GetHasBinaryDataHandler")]
			get {
				if (id_hasBinaryData == IntPtr.Zero)
					id_hasBinaryData = JNIEnv.GetMethodID (class_ref, "hasBinaryData", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBinaryData);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasBinaryData", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		static Delegate cb_setParams_Ljava_util_LinkedHashMap_;
#pragma warning disable 0169
		static Delegate GetSetParams_Ljava_util_LinkedHashMap_Handler ()
		{
			if (cb_setParams_Ljava_util_LinkedHashMap_ == null)
				cb_setParams_Ljava_util_LinkedHashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParams_Ljava_util_LinkedHashMap_);
			return cb_setParams_Ljava_util_LinkedHashMap_;
		}

		static void n_SetParams_Ljava_util_LinkedHashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.LinkedHashMap p0 = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Params = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParams;
		static IntPtr id_setParams_Ljava_util_LinkedHashMap_;
		public virtual unsafe global::Java.Util.LinkedHashMap Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/LinkedHashMap;", "GetGetParamsHandler")]
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/LinkedHashMap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParams", "()Ljava/util/LinkedHashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='setParams' and count(parameter)=1 and parameter[1][@type='java.util.LinkedHashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setParams", "(Ljava/util/LinkedHashMap;)V", "GetSetParams_Ljava_util_LinkedHashMap_Handler")]
			set {
				if (id_setParams_Ljava_util_LinkedHashMap_ == IntPtr.Zero)
					id_setParams_Ljava_util_LinkedHashMap_ = JNIEnv.GetMethodID (class_ref, "setParams", "(Ljava/util/LinkedHashMap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParams_Ljava_util_LinkedHashMap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParams", "(Ljava/util/LinkedHashMap;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_add_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_IHandler ()
		{
			if (cb_add_Ljava_lang_String_I == null)
				cb_add_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Add_Ljava_lang_String_I);
			return cb_add_Ljava_lang_String_I;
		}

		static void n_Add_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "(Ljava/lang/String;I)V", "GetAdd_Ljava_lang_String_IHandler")]
		public virtual unsafe void Add (string p0, int p1)
		{
			if (id_add_Ljava_lang_String_I == IntPtr.Zero)
				id_add_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_add_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_Ljava_lang_Object_);
			return cb_add_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Add_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAdd_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Add (string p0, global::Java.Lang.Object p1)
		{
			if (id_add_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_add_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Add_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Add (string p0, string p1)
		{
			if (id_add_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_add_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_JHandler ()
		{
			if (cb_add_Ljava_lang_String_J == null)
				cb_add_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Add_Ljava_lang_String_J);
			return cb_add_Ljava_lang_String_J;
		}

		static void n_Add_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Obsolete (@"deprecated")]
		[Register ("add", "(Ljava/lang/String;J)V", "GetAdd_Ljava_lang_String_JHandler")]
		public virtual unsafe void Add (string p0, long p1)
		{
			if (id_add_Ljava_lang_String_J == IntPtr.Zero)
				id_add_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainsKey (string p0)
		{
			if (id_containsKey_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsKey_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsKey", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_containsValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsValue_Ljava_lang_String_Handler ()
		{
			if (cb_containsValue_Ljava_lang_String_ == null)
				cb_containsValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsValue_Ljava_lang_String_);
			return cb_containsValue_Ljava_lang_String_;
		}

		static bool n_ContainsValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='containsValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsValue", "(Ljava/lang/String;)Z", "GetContainsValue_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainsValue (string p0)
		{
			if (id_containsValue_Ljava_lang_String_ == IntPtr.Zero)
				id_containsValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsValue", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsValue_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsValue", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_encodeUrl;
#pragma warning disable 0169
		static Delegate GetEncodeUrlHandler ()
		{
			if (cb_encodeUrl == null)
				cb_encodeUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeUrl);
			return cb_encodeUrl;
		}

		static IntPtr n_EncodeUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncodeUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_encodeUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='encodeUrl' and count(parameter)=0]"
		[Register ("encodeUrl", "()Ljava/lang/String;", "GetEncodeUrlHandler")]
		public virtual unsafe string EncodeUrl ()
		{
			if (id_encodeUrl == IntPtr.Zero)
				id_encodeUrl = JNIEnv.GetMethodID (class_ref, "encodeUrl", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		static IntPtr id_keySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()Ljava/util/Set;", "GetKeySetHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> KeySet ()
		{
			if (id_keySet == IntPtr.Zero)
				id_keySet = JNIEnv.GetMethodID (class_ref, "keySet", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keySet), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keySet", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Put (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_IHandler ()
		{
			if (cb_put_Ljava_lang_String_I == null)
				cb_put_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Put_Ljava_lang_String_I);
			return cb_put_Ljava_lang_String_I;
		}

		static void n_Put_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("put", "(Ljava/lang/String;I)V", "GetPut_Ljava_lang_String_IHandler")]
		public virtual unsafe void Put (string p0, int p1)
		{
			if (id_put_Ljava_lang_String_I == IntPtr.Zero)
				id_put_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_Object_);
			return cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Put (string p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_JHandler ()
		{
			if (cb_put_Ljava_lang_String_J == null)
				cb_put_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Put_Ljava_lang_String_J);
			return cb_put_Ljava_lang_String_J;
		}

		static void n_Put_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("put", "(Ljava/lang/String;J)V", "GetPut_Ljava_lang_String_JHandler")]
		public virtual unsafe void Put (string p0, long p1)
		{
			if (id_put_Ljava_lang_String_J == IntPtr.Zero)
				id_put_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='WeiboParameters']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
