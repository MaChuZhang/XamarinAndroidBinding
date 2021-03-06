using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/FailReason", DoNotGenerateAcw=true)]
	public partial class FailReason : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/FailReason$FailType", DoNotGenerateAcw=true)]
		public sealed partial class FailType : global::Java.Lang.Enum {


			static IntPtr DECODING_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='DECODING_ERROR']"
			[Register ("DECODING_ERROR")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType DecodingError {
				get {
					if (DECODING_ERROR_jfieldId == IntPtr.Zero)
						DECODING_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECODING_ERROR", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DECODING_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IO_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='IO_ERROR']"
			[Register ("IO_ERROR")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType IoError {
				get {
					if (IO_ERROR_jfieldId == IntPtr.Zero)
						IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_ERROR", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_DENIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='NETWORK_DENIED']"
			[Register ("NETWORK_DENIED")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType NetworkDenied {
				get {
					if (NETWORK_DENIED_jfieldId == IntPtr.Zero)
						NETWORK_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_DENIED", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_DENIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OUT_OF_MEMORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='OUT_OF_MEMORY']"
			[Register ("OUT_OF_MEMORY")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType OutOfMemory {
				get {
					if (OUT_OF_MEMORY_jfieldId == IntPtr.Zero)
						OUT_OF_MEMORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUT_OF_MEMORY", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUT_OF_MEMORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/FailReason$FailType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FailType); }
			}

			internal FailType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;", "")]
			public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;", "")]
			public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
				try {
					return (global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/FailReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FailReason); }
		}

		protected FailReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']/constructor[@name='FailReason' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.FailReason.FailType'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V", "")]
		public unsafe FailReason (global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FailReason)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static Delegate cb_getCause;
#pragma warning disable 0169
		static Delegate GetGetCauseHandler ()
		{
			if (cb_getCause == null)
				cb_getCause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCause);
			return cb_getCause;
		}

		static IntPtr n_GetCause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cause);
		}
#pragma warning restore 0169

		static IntPtr id_getCause;
		public virtual unsafe global::Java.Lang.Throwable Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Ljava/lang/Throwable;", "GetGetCauseHandler")]
			get {
				if (id_getCause == IntPtr.Zero)
					id_getCause = JNIEnv.GetMethodID (class_ref, "getCause", "()Ljava/lang/Throwable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCause), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCause", "()Ljava/lang/Throwable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
