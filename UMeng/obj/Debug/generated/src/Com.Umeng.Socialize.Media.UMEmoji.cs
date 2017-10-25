using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMEmoji", DoNotGenerateAcw=true)]
	public partial class UMEmoji : global::Com.Umeng.Socialize.Media.UMImage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/UMEmoji", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMEmoji); }
		}

		protected UMEmoji (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.umeng.social.tool.UMImageMark']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/Bitmap;Lcom/umeng/social/tool/UMImageMark;)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1, global::Com.Umeng.Social.Tool.UMImageMark p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.umeng.social.tool.UMImageMark']]"
		[Register (".ctor", "(Landroid/content/Context;ILcom/umeng/social/tool/UMImageMark;)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, int p1, global::Com.Umeng.Social.Tool.UMImageMark p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.umeng.social.tool.UMImageMark']]"
		[Register (".ctor", "(Landroid/content/Context;[BLcom/umeng/social/tool/UMImageMark;)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, byte[] p1, global::Com.Umeng.Social.Tool.UMImageMark p2)
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
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/io/File;)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, global::Java.IO.File p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UMEmoji)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMEmoji']/constructor[@name='UMEmoji' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Landroid/content/Context;[B)V", "")]
		public unsafe UMEmoji (global::Android.Content.Context p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (UMEmoji)) {
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

	}
}
