using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage", DoNotGenerateAcw=true)]
	public partial class UMImage : global::Com.Umeng.Socialize.Media.BaseMediaObject {


		static IntPtr BINARY_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='BINARY_IMAGE']"
		[Register ("BINARY_IMAGE")]
		public static int BinaryImage {
			get {
				if (BINARY_IMAGE_jfieldId == IntPtr.Zero)
					BINARY_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BINARY_IMAGE", "I");
				return JNIEnv.GetStaticIntField (class_ref, BINARY_IMAGE_jfieldId);
			}
			set {
				if (BINARY_IMAGE_jfieldId == IntPtr.Zero)
					BINARY_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BINARY_IMAGE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BINARY_IMAGE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr BITMAP_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='BITMAP_IMAGE']"
		[Register ("BITMAP_IMAGE")]
		public static int BitmapImage {
			get {
				if (BITMAP_IMAGE_jfieldId == IntPtr.Zero)
					BITMAP_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BITMAP_IMAGE", "I");
				return JNIEnv.GetStaticIntField (class_ref, BITMAP_IMAGE_jfieldId);
			}
			set {
				if (BITMAP_IMAGE_jfieldId == IntPtr.Zero)
					BITMAP_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BITMAP_IMAGE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BITMAP_IMAGE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr FILE_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='FILE_IMAGE']"
		[Register ("FILE_IMAGE")]
		public static int FileImage {
			get {
				if (FILE_IMAGE_jfieldId == IntPtr.Zero)
					FILE_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_IMAGE", "I");
				return JNIEnv.GetStaticIntField (class_ref, FILE_IMAGE_jfieldId);
			}
			set {
				if (FILE_IMAGE_jfieldId == IntPtr.Zero)
					FILE_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_IMAGE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, FILE_IMAGE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MAX_HEIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='MAX_HEIGHT']"
		[Register ("MAX_HEIGHT")]
		public static int MaxHeight {
			get {
				if (MAX_HEIGHT_jfieldId == IntPtr.Zero)
					MAX_HEIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_HEIGHT", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_HEIGHT_jfieldId);
			}
			set {
				if (MAX_HEIGHT_jfieldId == IntPtr.Zero)
					MAX_HEIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_HEIGHT", "I");
				try {
					JNIEnv.SetStaticField (class_ref, MAX_HEIGHT_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MAX_WIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='MAX_WIDTH']"
		[Register ("MAX_WIDTH")]
		public static int MaxWidth {
			get {
				if (MAX_WIDTH_jfieldId == IntPtr.Zero)
					MAX_WIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_WIDTH", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_WIDTH_jfieldId);
			}
			set {
				if (MAX_WIDTH_jfieldId == IntPtr.Zero)
					MAX_WIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_WIDTH", "I");
				try {
					JNIEnv.SetStaticField (class_ref, MAX_WIDTH_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr RES_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='RES_IMAGE']"
		[Register ("RES_IMAGE")]
		public static int ResImage {
			get {
				if (RES_IMAGE_jfieldId == IntPtr.Zero)
					RES_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RES_IMAGE", "I");
				return JNIEnv.GetStaticIntField (class_ref, RES_IMAGE_jfieldId);
			}
			set {
				if (RES_IMAGE_jfieldId == IntPtr.Zero)
					RES_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RES_IMAGE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, RES_IMAGE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr URL_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='URL_IMAGE']"
		[Register ("URL_IMAGE")]
		public static int UrlImage {
			get {
				if (URL_IMAGE_jfieldId == IntPtr.Zero)
					URL_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URL_IMAGE", "I");
				return JNIEnv.GetStaticIntField (class_ref, URL_IMAGE_jfieldId);
			}
			set {
				if (URL_IMAGE_jfieldId == IntPtr.Zero)
					URL_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URL_IMAGE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, URL_IMAGE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr compressFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='compressFormat']"
		[Register ("compressFormat")]
		public global::Android.Graphics.Bitmap.CompressFormat CompressFormat {
			get {
				if (compressFormat_jfieldId == IntPtr.Zero)
					compressFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "compressFormat", "Landroid/graphics/Bitmap$CompressFormat;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, compressFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (compressFormat_jfieldId == IntPtr.Zero)
					compressFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "compressFormat", "Landroid/graphics/Bitmap$CompressFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, compressFormat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr isLoadImgByCompress_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/field[@name='isLoadImgByCompress']"
		[Register ("isLoadImgByCompress")]
		public bool IsLoadImgByCompress {
			get {
				if (isLoadImgByCompress_jfieldId == IntPtr.Zero)
					isLoadImgByCompress_jfieldId = JNIEnv.GetFieldID (class_ref, "isLoadImgByCompress", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isLoadImgByCompress_jfieldId);
			}
			set {
				if (isLoadImgByCompress_jfieldId == IntPtr.Zero)
					isLoadImgByCompress_jfieldId = JNIEnv.GetFieldID (class_ref, "isLoadImgByCompress", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isLoadImgByCompress_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BinaryConvertor']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$BinaryConvertor", DoNotGenerateAcw=true)]
		public partial class BinaryConvertor : global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$BinaryConvertor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BinaryConvertor); }
			}

			protected BinaryConvertor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_media_UMImage_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BinaryConvertor']/constructor[@name='UMImage.BinaryConvertor' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.media.UMImage'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(Lcom/umeng/socialize/media/UMImage;[B)V", "")]
			public unsafe BinaryConvertor (global::Com.Umeng.Socialize.Media.UMImage __self, byte[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (BinaryConvertor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[B)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_media_UMImage_arrayB == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_media_UMImage_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/media/UMImage;[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_arrayB, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BinaryConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public override unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				try {

					if (GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinary", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			static IntPtr id_asBitmap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BinaryConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public override unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			static IntPtr id_asFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BinaryConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public override unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BinaryConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			static IntPtr id_asUrl;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BinaryConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public override unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BitmapConvertor']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$BitmapConvertor", DoNotGenerateAcw=true)]
		public partial class BitmapConvertor : global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$BitmapConvertor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BitmapConvertor); }
			}

			protected BitmapConvertor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BitmapConvertor']/constructor[@name='UMImage.BitmapConvertor' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.media.UMImage'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register (".ctor", "(Lcom/umeng/socialize/media/UMImage;Landroid/graphics/Bitmap;)V", "")]
			public unsafe BitmapConvertor (global::Com.Umeng.Socialize.Media.UMImage __self, global::Android.Graphics.Bitmap p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (BitmapConvertor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/media/UMImage;Landroid/graphics/Bitmap;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_graphics_Bitmap_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_graphics_Bitmap_, __args);
				} finally {
				}
			}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BitmapConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public override unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				try {

					if (GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinary", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			static IntPtr id_asBitmap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BitmapConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public override unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			static IntPtr id_asFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BitmapConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public override unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.BitmapConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			static IntPtr id_asUrl;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.BitmapConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public override unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.CompressStyle']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$CompressStyle", DoNotGenerateAcw=true)]
		public sealed partial class CompressStyle : global::Java.Lang.Enum {


			static IntPtr QUALITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.CompressStyle']/field[@name='QUALITY']"
			[Register ("QUALITY")]
			public static global::Com.Umeng.Socialize.Media.UMImage.CompressStyle Quality {
				get {
					if (QUALITY_jfieldId == IntPtr.Zero)
						QUALITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUALITY", "Lcom/umeng/socialize/media/UMImage$CompressStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUALITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.CompressStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.CompressStyle']/field[@name='SCALE']"
			[Register ("SCALE")]
			public static global::Com.Umeng.Socialize.Media.UMImage.CompressStyle Scale {
				get {
					if (SCALE_jfieldId == IntPtr.Zero)
						SCALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCALE", "Lcom/umeng/socialize/media/UMImage$CompressStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.CompressStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$CompressStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CompressStyle); }
			}

			internal CompressStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.CompressStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/media/UMImage$CompressStyle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Media.UMImage.CompressStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/media/UMImage$CompressStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Media.UMImage.CompressStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.CompressStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.CompressStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/media/UMImage$CompressStyle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Media.UMImage.CompressStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/media/UMImage$CompressStyle;");
				try {
					return (global::Com.Umeng.Socialize.Media.UMImage.CompressStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Media.UMImage.CompressStyle));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ConfiguredConvertor']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$ConfiguredConvertor", DoNotGenerateAcw=true)]
		public abstract partial class ConfiguredConvertor : global::Java.Lang.Object, global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor {

			protected ConfiguredConvertor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public abstract byte[] AsBinary ();

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public abstract global::Android.Graphics.Bitmap AsBitmap ();

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public abstract global::Java.IO.File AsFile ();

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public abstract string AsUrl ();

		}

		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$ConfiguredConvertor", DoNotGenerateAcw=true)]
		internal partial class ConfiguredConvertorInvoker : ConfiguredConvertor {

			public ConfiguredConvertorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConfiguredConvertorInvoker); }
			}

			static IntPtr id_asBinary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public override unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				try {
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static IntPtr id_asBitmap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public override unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_asFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public override unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_asUrl;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public override unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.FileConvertor']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$FileConvertor", DoNotGenerateAcw=true)]
		public partial class FileConvertor : global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$FileConvertor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileConvertor); }
			}

			protected FileConvertor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_io_File_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.FileConvertor']/constructor[@name='UMImage.FileConvertor' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.media.UMImage'] and parameter[2][@type='java.io.File']]"
			[Register (".ctor", "(Lcom/umeng/socialize/media/UMImage;Ljava/io/File;)V", "")]
			public unsafe FileConvertor (global::Com.Umeng.Socialize.Media.UMImage __self, global::Java.IO.File p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FileConvertor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/io/File;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/io/File;)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_io_File_ == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/media/UMImage;Ljava/io/File;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_io_File_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_io_File_, __args);
				} finally {
				}
			}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.FileConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.FileConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.FileConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public override unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				try {

					if (GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinary", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.FileConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.FileConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			static IntPtr id_asBitmap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.FileConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public override unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.FileConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.FileConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			static IntPtr id_asFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.FileConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public override unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.FileConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.FileConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			static IntPtr id_asUrl;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.FileConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public override unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']"
		[Register ("com/umeng/socialize/media/UMImage$IImageConvertor", "", "Com.Umeng.Socialize.Media.UMImage/IImageConvertorInvoker")]
		public partial interface IImageConvertor : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler:Com.Umeng.Socialize.Media.UMImage/IImageConvertorInvoker, UMeng")]
			byte[] AsBinary ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler:Com.Umeng.Socialize.Media.UMImage/IImageConvertorInvoker, UMeng")]
			global::Android.Graphics.Bitmap AsBitmap ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler:Com.Umeng.Socialize.Media.UMImage/IImageConvertorInvoker, UMeng")]
			global::Java.IO.File AsFile ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMImage.IImageConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler:Com.Umeng.Socialize.Media.UMImage/IImageConvertorInvoker, UMeng")]
			string AsUrl ();

		}

		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$IImageConvertor", DoNotGenerateAcw=true)]
		internal class IImageConvertorInvoker : global::Java.Lang.Object, IImageConvertor {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$IImageConvertor");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IImageConvertorInvoker); }
			}

			IntPtr class_ref;

			public static IImageConvertor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IImageConvertor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.media.UMImage.IImageConvertor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IImageConvertorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			IntPtr id_asBinary;
			public unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
			}

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			IntPtr id_asBitmap;
			public unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			IntPtr id_asFile;
			public unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.IImageConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			IntPtr id_asUrl;
			public unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ResConvertor']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$ResConvertor", DoNotGenerateAcw=true)]
		public partial class ResConvertor : global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$ResConvertor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResConvertor); }
			}

			protected ResConvertor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_content_Context_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ResConvertor']/constructor[@name='UMImage.ResConvertor' and count(parameter)=3 and parameter[1][@type='com.umeng.socialize.media.UMImage'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lcom/umeng/socialize/media/UMImage;Landroid/content/Context;I)V", "")]
			public unsafe ResConvertor (global::Com.Umeng.Socialize.Media.UMImage __self, global::Android.Content.Context p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (ResConvertor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;I)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_content_Context_I == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/media/UMImage;Landroid/content/Context;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_content_Context_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Landroid_content_Context_I, __args);
				} finally {
				}
			}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ResConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ResConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ResConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public override unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				try {

					if (GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinary", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ResConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ResConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			static IntPtr id_asBitmap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ResConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public override unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ResConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ResConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			static IntPtr id_asFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ResConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public override unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.ResConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.ResConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			static IntPtr id_asUrl;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.ResConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public override unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.UrlConvertor']"
		[global::Android.Runtime.Register ("com/umeng/socialize/media/UMImage$UrlConvertor", DoNotGenerateAcw=true)]
		public partial class UrlConvertor : global::Com.Umeng.Socialize.Media.UMImage.ConfiguredConvertor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage$UrlConvertor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UrlConvertor); }
			}

			protected UrlConvertor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.UrlConvertor']/constructor[@name='UMImage.UrlConvertor' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.media.UMImage'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/umeng/socialize/media/UMImage;Ljava/lang/String;)V", "")]
			public unsafe UrlConvertor (global::Com.Umeng.Socialize.Media.UMImage __self, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (UrlConvertor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/media/UMImage;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_media_UMImage_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_asBinary;
#pragma warning disable 0169
			static Delegate GetAsBinaryHandler ()
			{
				if (cb_asBinary == null)
					cb_asBinary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinary);
				return cb_asBinary;
			}

			static IntPtr n_AsBinary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.AsBinary ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.UrlConvertor']/method[@name='asBinary' and count(parameter)=0]"
			[Register ("asBinary", "()[B", "GetAsBinaryHandler")]
			public override unsafe byte[] AsBinary ()
			{
				if (id_asBinary == IntPtr.Zero)
					id_asBinary = JNIEnv.GetMethodID (class_ref, "asBinary", "()[B");
				try {

					if (GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinary), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinary", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_asBitmap;
#pragma warning disable 0169
			static Delegate GetAsBitmapHandler ()
			{
				if (cb_asBitmap == null)
					cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
				return cb_asBitmap;
			}

			static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
			}
#pragma warning restore 0169

			static IntPtr id_asBitmap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.UrlConvertor']/method[@name='asBitmap' and count(parameter)=0]"
			[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
			public override unsafe global::Android.Graphics.Bitmap AsBitmap ()
			{
				if (id_asBitmap == IntPtr.Zero)
					id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asFile;
#pragma warning disable 0169
			static Delegate GetAsFileHandler ()
			{
				if (cb_asFile == null)
					cb_asFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFile);
				return cb_asFile;
			}

			static IntPtr n_AsFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsFile ());
			}
#pragma warning restore 0169

			static IntPtr id_asFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.UrlConvertor']/method[@name='asFile' and count(parameter)=0]"
			[Register ("asFile", "()Ljava/io/File;", "GetAsFileHandler")]
			public override unsafe global::Java.IO.File AsFile ()
			{
				if (id_asFile == IntPtr.Zero)
					id_asFile = JNIEnv.GetMethodID (class_ref, "asFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_asUrl;
#pragma warning disable 0169
			static Delegate GetAsUrlHandler ()
			{
				if (cb_asUrl == null)
					cb_asUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrl);
				return cb_asUrl;
			}

			static IntPtr n_AsUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage.UrlConvertor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AsUrl ());
			}
#pragma warning restore 0169

			static IntPtr id_asUrl;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage.UrlConvertor']/method[@name='asUrl' and count(parameter)=0]"
			[Register ("asUrl", "()Ljava/lang/String;", "GetAsUrlHandler")]
			public override unsafe string AsUrl ()
			{
				if (id_asUrl == IntPtr.Zero)
					id_asUrl = JNIEnv.GetMethodID (class_ref, "asUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/UMImage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMImage); }
		}

		protected UMImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_Lcom_umeng_social_tool_UMImageMark_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.umeng.social.tool.UMImageMark']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/Bitmap;Lcom/umeng/social/tool/UMImageMark;)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1, global::Com.Umeng.Social.Tool.UMImageMark p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/graphics/Bitmap;Lcom/umeng/social/tool/UMImageMark;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/graphics/Bitmap;Lcom/umeng/social/tool/UMImageMark;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_Lcom_umeng_social_tool_UMImageMark_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_Lcom_umeng_social_tool_UMImageMark_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;Lcom/umeng/social/tool/UMImageMark;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_Lcom_umeng_social_tool_UMImageMark_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_Lcom_umeng_social_tool_UMImageMark_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ILcom_umeng_social_tool_UMImageMark_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.umeng.social.tool.UMImageMark']]"
		[Register (".ctor", "(Landroid/content/Context;ILcom/umeng/social/tool/UMImageMark;)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, int p1, global::Com.Umeng.Social.Tool.UMImageMark p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ILcom/umeng/social/tool/UMImageMark;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILcom/umeng/social/tool/UMImageMark;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILcom_umeng_social_tool_UMImageMark_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILcom_umeng_social_tool_UMImageMark_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILcom/umeng/social/tool/UMImageMark;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILcom_umeng_social_tool_UMImageMark_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILcom_umeng_social_tool_UMImageMark_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_arrayBLcom_umeng_social_tool_UMImageMark_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.umeng.social.tool.UMImageMark']]"
		[Register (".ctor", "(Landroid/content/Context;[BLcom/umeng/social/tool/UMImageMark;)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, byte[] p1, global::Com.Umeng.Social.Tool.UMImageMark p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;[BLcom/umeng/social/tool/UMImageMark;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[BLcom/umeng/social/tool/UMImageMark;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayBLcom_umeng_social_tool_UMImageMark_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayBLcom_umeng_social_tool_UMImageMark_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[BLcom/umeng/social/tool/UMImageMark;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayBLcom_umeng_social_tool_UMImageMark_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayBLcom_umeng_social_tool_UMImageMark_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/io/File;)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, global::Java.IO.File p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_io_File_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/constructor[@name='UMImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Landroid/content/Context;[B)V", "")]
		public unsafe UMImage (global::Android.Content.Context p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (UMImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[B)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayB == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayB, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getImageStyle;
#pragma warning disable 0169
		static Delegate GetGetImageStyleHandler ()
		{
			if (cb_getImageStyle == null)
				cb_getImageStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageStyle);
			return cb_getImageStyle;
		}

		static int n_GetImageStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageStyle;
		}
#pragma warning restore 0169

		static IntPtr id_getImageStyle;
		public virtual unsafe int ImageStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='getImageStyle' and count(parameter)=0]"
			[Register ("getImageStyle", "()I", "GetGetImageStyleHandler")]
			get {
				if (id_getImageStyle == IntPtr.Zero)
					id_getImageStyle = JNIEnv.GetMethodID (class_ref, "getImageStyle", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageStyle);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageStyle", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isHasWaterMark;
#pragma warning disable 0169
		static Delegate GetIsHasWaterMarkHandler ()
		{
			if (cb_isHasWaterMark == null)
				cb_isHasWaterMark = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHasWaterMark);
			return cb_isHasWaterMark;
		}

		static bool n_IsHasWaterMark (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHasWaterMark;
		}
#pragma warning restore 0169

		static IntPtr id_isHasWaterMark;
		public virtual unsafe bool IsHasWaterMark {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='isHasWaterMark' and count(parameter)=0]"
			[Register ("isHasWaterMark", "()Z", "GetIsHasWaterMarkHandler")]
			get {
				if (id_isHasWaterMark == IntPtr.Zero)
					id_isHasWaterMark = JNIEnv.GetMethodID (class_ref, "isHasWaterMark", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHasWaterMark);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHasWaterMark", "()Z"));
				} finally {
				}
			}
		}

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
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaType;
		public override unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;", "GetGetMediaTypeHandler")]
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinImage;
#pragma warning disable 0169
		static Delegate GetAsBinImageHandler ()
		{
			if (cb_asBinImage == null)
				cb_asBinImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinImage);
			return cb_asBinImage;
		}

		static IntPtr n_AsBinImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.AsBinImage ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='asBinImage' and count(parameter)=0]"
		[Register ("asBinImage", "()[B", "GetAsBinImageHandler")]
		public virtual unsafe byte[] AsBinImage ()
		{
			if (id_asBinImage == IntPtr.Zero)
				id_asBinImage = JNIEnv.GetMethodID (class_ref, "asBinImage", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinImage), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinImage", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_asBitmap;
#pragma warning disable 0169
		static Delegate GetAsBitmapHandler ()
		{
			if (cb_asBitmap == null)
				cb_asBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBitmap);
			return cb_asBitmap;
		}

		static IntPtr n_AsBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBitmap ());
		}
#pragma warning restore 0169

		static IntPtr id_asBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='asBitmap' and count(parameter)=0]"
		[Register ("asBitmap", "()Landroid/graphics/Bitmap;", "GetAsBitmapHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap AsBitmap ()
		{
			if (id_asBitmap == IntPtr.Zero)
				id_asBitmap = JNIEnv.GetMethodID (class_ref, "asBitmap", "()Landroid/graphics/Bitmap;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBitmap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asFileImage;
#pragma warning disable 0169
		static Delegate GetAsFileImageHandler ()
		{
			if (cb_asFileImage == null)
				cb_asFileImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsFileImage);
			return cb_asFileImage;
		}

		static IntPtr n_AsFileImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsFileImage ());
		}
#pragma warning restore 0169

		static IntPtr id_asFileImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='asFileImage' and count(parameter)=0]"
		[Register ("asFileImage", "()Ljava/io/File;", "GetAsFileImageHandler")]
		public virtual unsafe global::Java.IO.File AsFileImage ()
		{
			if (id_asFileImage == IntPtr.Zero)
				id_asFileImage = JNIEnv.GetMethodID (class_ref, "asFileImage", "()Ljava/io/File;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asFileImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asFileImage", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asUrlImage;
#pragma warning disable 0169
		static Delegate GetAsUrlImageHandler ()
		{
			if (cb_asUrlImage == null)
				cb_asUrlImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsUrlImage);
			return cb_asUrlImage;
		}

		static IntPtr n_AsUrlImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsUrlImage ());
		}
#pragma warning restore 0169

		static IntPtr id_asUrlImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='asUrlImage' and count(parameter)=0]"
		[Register ("asUrlImage", "()Ljava/lang/String;", "GetAsUrlImageHandler")]
		public virtual unsafe string AsUrlImage ()
		{
			if (id_asUrlImage == IntPtr.Zero)
				id_asUrlImage = JNIEnv.GetMethodID (class_ref, "asUrlImage", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asUrlImage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asUrlImage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Umeng.Socialize.Media.UMImage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByte ());
		}
#pragma warning restore 0169

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()[B", "GetToByteHandler")]
		public override unsafe byte[] ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByte), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByte", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_toUrlExtraParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMImage']/method[@name='toUrlExtraParams' and count(parameter)=0]"
		[Register ("toUrlExtraParams", "()Ljava/util/Map;", "")]
		public override sealed unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ()
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
