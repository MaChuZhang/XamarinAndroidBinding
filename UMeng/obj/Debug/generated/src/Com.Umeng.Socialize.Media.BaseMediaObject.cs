using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/BaseMediaObject", DoNotGenerateAcw=true)]
	public abstract partial class BaseMediaObject : global::Java.Lang.Object, global::Com.Umeng.Socialize.Media.IUMediaObject {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/field[@name='a']"
		[Register ("a")]
		protected string A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/field[@name='b']"
		[Register ("b")]
		protected string B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/field[@name='c']"
		[Register ("c")]
		protected global::System.Collections.IDictionary C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/field[@name='d']"
		[Register ("d")]
		protected string D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, d_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, d_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/field[@name='e']"
		[Register ("e")]
		protected global::Com.Umeng.Socialize.Media.UMImage E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Lcom/umeng/socialize/media/UMImage;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Lcom/umeng/socialize/media/UMImage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mText_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/field[@name='mText']"
		[Register ("mText")]
		public string MText {
			get {
				if (mText_jfieldId == IntPtr.Zero)
					mText_jfieldId = JNIEnv.GetFieldID (class_ref, "mText", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mText_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mText_jfieldId == IntPtr.Zero)
					mText_jfieldId = JNIEnv.GetFieldID (class_ref, "mText", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mText_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/BaseMediaObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMediaObject); }
		}

		protected BaseMediaObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/constructor[@name='BaseMediaObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BaseMediaObject (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BaseMediaObject)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/constructor[@name='BaseMediaObject' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BaseMediaObject (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseMediaObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/constructor[@name='BaseMediaObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMediaObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseMediaObject)) {
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isUrlMedia;
#pragma warning disable 0169
		static Delegate GetIsUrlMediaHandler ()
		{
			if (cb_isUrlMedia == null)
				cb_isUrlMedia = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUrlMedia);
			return cb_isUrlMedia;
		}

		static bool n_IsUrlMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUrlMedia;
		}
#pragma warning restore 0169

		static IntPtr id_isUrlMedia;
		public virtual unsafe bool IsUrlMedia {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='isUrlMedia' and count(parameter)=0]"
			[Register ("isUrlMedia", "()Z", "GetIsUrlMediaHandler")]
			get {
				if (id_isUrlMedia == IntPtr.Zero)
					id_isUrlMedia = JNIEnv.GetMethodID (class_ref, "isUrlMedia", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUrlMedia);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUrlMedia", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getThumbImage;
#pragma warning disable 0169
		static Delegate GetGetThumbImageHandler ()
		{
			if (cb_getThumbImage == null)
				cb_getThumbImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbImage);
			return cb_getThumbImage;
		}

		static IntPtr n_GetThumbImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThumbImage);
		}
#pragma warning restore 0169

		static IntPtr id_getThumbImage;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMImage ThumbImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='getThumbImage' and count(parameter)=0]"
			[Register ("getThumbImage", "()Lcom/umeng/socialize/media/UMImage;", "GetGetThumbImageHandler")]
			get {
				if (id_getThumbImage == IntPtr.Zero)
					id_getThumbImage = JNIEnv.GetMethodID (class_ref, "getThumbImage", "()Lcom/umeng/socialize/media/UMImage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThumbImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbImage", "()Lcom/umeng/socialize/media/UMImage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getmExtra;
#pragma warning disable 0169
		static Delegate GetGetmExtraHandler ()
		{
			if (cb_getmExtra == null)
				cb_getmExtra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetmExtra);
			return cb_getmExtra;
		}

		static IntPtr n_GetmExtra (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetmExtra ());
		}
#pragma warning restore 0169

		static IntPtr id_getmExtra;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='getmExtra' and count(parameter)=0]"
		[Register ("getmExtra", "()Ljava/util/Map;", "GetGetmExtraHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetmExtra ()
		{
			if (id_getmExtra == IntPtr.Zero)
				id_getmExtra = JNIEnv.GetMethodID (class_ref, "getmExtra", "()Ljava/util/Map;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmExtra), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmExtra", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setThumb_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetSetThumb_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_setThumb_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_setThumb_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetThumb_Lcom_umeng_socialize_media_UMImage_);
			return cb_setThumb_Lcom_umeng_socialize_media_UMImage_;
		}

		static void n_SetThumb_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetThumb (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setThumb_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='setThumb' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("setThumb", "(Lcom/umeng/socialize/media/UMImage;)V", "GetSetThumb_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe void SetThumb (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_setThumb_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_setThumb_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "setThumb", "(Lcom/umeng/socialize/media/UMImage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThumb_Lcom_umeng_socialize_media_UMImage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumb", "(Lcom/umeng/socialize/media/UMImage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetmExtra_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setmExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setmExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetmExtra_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setmExtra_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetmExtra_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetmExtra (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setmExtra_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='setmExtra' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setmExtra", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetmExtra_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetmExtra (string p0, global::Java.Lang.Object p1)
		{
			if (id_setmExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setmExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setmExtra", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmExtra_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmExtra", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toUrl;
#pragma warning disable 0169
		static Delegate GetToUrlHandler ()
		{
			if (cb_toUrl == null)
				cb_toUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUrl);
			return cb_toUrl;
		}

		static IntPtr n_ToUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_toUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='toUrl' and count(parameter)=0]"
		[Register ("toUrl", "()Ljava/lang/String;", "GetToUrlHandler")]
		public virtual unsafe string ToUrl ()
		{
			if (id_toUrl == IntPtr.Zero)
				id_toUrl = JNIEnv.GetMethodID (class_ref, "toUrl", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByte;
#pragma warning disable 0169
		static Delegate GetToByteHandler ()
		{
			if (cb_toByte == null)
				cb_toByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByte);
			return cb_toByte;
		}

		static IntPtr n_ToByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByte ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()[B", "GetToByteHandler")]
		public abstract byte[] ToByte ();

		static Delegate cb_toUrlExtraParams;
#pragma warning disable 0169
		static Delegate GetToUrlExtraParamsHandler ()
		{
			if (cb_toUrlExtraParams == null)
				cb_toUrlExtraParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUrlExtraParams);
			return cb_toUrlExtraParams;
		}

		static IntPtr n_ToUrlExtraParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ToUrlExtraParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toUrlExtraParams' and count(parameter)=0]"
		[Register ("toUrlExtraParams", "()Ljava/util/Map;", "GetToUrlExtraParamsHandler")]
		public abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ();

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		public abstract global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;", "GetGetMediaTypeHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/media/BaseMediaObject", DoNotGenerateAcw=true)]
	internal partial class BaseMediaObjectInvoker : BaseMediaObject {

		public BaseMediaObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMediaObjectInvoker); }
		}

		static IntPtr id_getMediaType;
		public override unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='BaseMediaObject']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;", "GetGetMediaTypeHandler")]
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()[B", "GetToByteHandler")]
		public override unsafe byte[] ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByte), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_toUrlExtraParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toUrlExtraParams' and count(parameter)=0]"
		[Register ("toUrlExtraParams", "()Ljava/util/Map;", "GetToUrlExtraParamsHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ()
		{
			if (id_toUrlExtraParams == IntPtr.Zero)
				id_toUrlExtraParams = JNIEnv.GetMethodID (class_ref, "toUrlExtraParams", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUrlExtraParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
