using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Naming {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.naming']/class[@name='Md5FileNameGenerator']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/naming/Md5FileNameGenerator", DoNotGenerateAcw=true)]
	public partial class Md5FileNameGenerator : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/naming/Md5FileNameGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Md5FileNameGenerator); }
		}

		protected Md5FileNameGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.naming']/class[@name='Md5FileNameGenerator']/constructor[@name='Md5FileNameGenerator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Md5FileNameGenerator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Md5FileNameGenerator)) {
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

		static Delegate cb_generate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerate_Ljava_lang_String_Handler ()
		{
			if (cb_generate_Ljava_lang_String_ == null)
				cb_generate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Generate_Ljava_lang_String_);
			return cb_generate_Ljava_lang_String_;
		}

		static IntPtr n_Generate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.Md5FileNameGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.Md5FileNameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Generate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.naming']/class[@name='Md5FileNameGenerator']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generate", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerate_Ljava_lang_String_Handler")]
		public virtual unsafe string Generate (string p0)
		{
			if (id_generate_Ljava_lang_String_ == IntPtr.Zero)
				id_generate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generate", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
