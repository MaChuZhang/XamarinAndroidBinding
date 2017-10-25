using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Social.Tool {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']"
	[global::Android.Runtime.Register ("com/umeng/social/tool/ComposeTool", DoNotGenerateAcw=true)]
	public partial class ComposeTool : global::Java.Lang.Object {


		static IntPtr backgroundColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/field[@name='backgroundColor']"
		[Register ("backgroundColor")]
		public static int BackgroundColor {
			get {
				if (backgroundColor_jfieldId == IntPtr.Zero)
					backgroundColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "backgroundColor", "I");
				return JNIEnv.GetStaticIntField (class_ref, backgroundColor_jfieldId);
			}
			set {
				if (backgroundColor_jfieldId == IntPtr.Zero)
					backgroundColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "backgroundColor", "I");
				try {
					JNIEnv.SetStaticField (class_ref, backgroundColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr direction_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/field[@name='direction']"
		[Register ("direction")]
		public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Direction {
			get {
				if (direction_jfieldId == IntPtr.Zero)
					direction_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "direction", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, direction_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (direction_jfieldId == IntPtr.Zero)
					direction_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "direction", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, direction_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr textColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/field[@name='textColor']"
		[Register ("textColor")]
		public static int TextColor {
			get {
				if (textColor_jfieldId == IntPtr.Zero)
					textColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "textColor", "I");
				return JNIEnv.GetStaticIntField (class_ref, textColor_jfieldId);
			}
			set {
				if (textColor_jfieldId == IntPtr.Zero)
					textColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "textColor", "I");
				try {
					JNIEnv.SetStaticField (class_ref, textColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr textsize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/field[@name='textsize']"
		[Register ("textsize")]
		public static int Textsize {
			get {
				if (textsize_jfieldId == IntPtr.Zero)
					textsize_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "textsize", "I");
				return JNIEnv.GetStaticIntField (class_ref, textsize_jfieldId);
			}
			set {
				if (textsize_jfieldId == IntPtr.Zero)
					textsize_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "textsize", "I");
				try {
					JNIEnv.SetStaticField (class_ref, textsize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr typeface_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/field[@name='typeface']"
		[Register ("typeface")]
		public static global::Android.Graphics.Typeface Typeface {
			get {
				if (typeface_jfieldId == IntPtr.Zero)
					typeface_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "typeface", "Landroid/graphics/Typeface;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, typeface_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (typeface_jfieldId == IntPtr.Zero)
					typeface_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "typeface", "Landroid/graphics/Typeface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, typeface_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']"
		[global::Android.Runtime.Register ("com/umeng/social/tool/ComposeTool$ComposeDirection", DoNotGenerateAcw=true)]
		public sealed partial class ComposeDirection : global::Java.Lang.Enum {


			static IntPtr CUSTOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='CUSTOM']"
			[Register ("CUSTOM")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Custom {
				get {
					if (CUSTOM_jfieldId == IntPtr.Zero)
						CUSTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='DOWN']"
			[Register ("DOWN")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Down {
				get {
					if (DOWN_jfieldId == IntPtr.Zero)
						DOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWN", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Left {
				get {
					if (LEFT_jfieldId == IntPtr.Zero)
						LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFTDOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='LEFTDOWN']"
			[Register ("LEFTDOWN")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Leftdown {
				get {
					if (LEFTDOWN_jfieldId == IntPtr.Zero)
						LEFTDOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFTDOWN", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFTDOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFTUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='LEFTUP']"
			[Register ("LEFTUP")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Leftup {
				get {
					if (LEFTUP_jfieldId == IntPtr.Zero)
						LEFTUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFTUP", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFTUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Right {
				get {
					if (RIGHT_jfieldId == IntPtr.Zero)
						RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHTDOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='RIGHTDOWN']"
			[Register ("RIGHTDOWN")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Rightdown {
				get {
					if (RIGHTDOWN_jfieldId == IntPtr.Zero)
						RIGHTDOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHTDOWN", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHTDOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHTUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='RIGHTUP']"
			[Register ("RIGHTUP")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Rightup {
				get {
					if (RIGHTUP_jfieldId == IntPtr.Zero)
						RIGHTUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHTUP", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHTUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/field[@name='UP']"
			[Register ("UP")]
			public static global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection Up {
				get {
					if (UP_jfieldId == IntPtr.Zero)
						UP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UP", "Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/social/tool/ComposeTool$ComposeDirection", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ComposeDirection); }
			}

			internal ComposeDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/social/tool/ComposeTool$ComposeDirection;", "")]
			public static unsafe global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool.ComposeDirection']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/social/tool/ComposeTool$ComposeDirection;", "")]
			public static unsafe global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/social/tool/ComposeTool$ComposeDirection;");
				try {
					return (global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Social.Tool.ComposeTool.ComposeDirection));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/social/tool/ComposeTool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ComposeTool); }
		}

		protected ComposeTool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/constructor[@name='ComposeTool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ComposeTool ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ComposeTool)) {
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

		static IntPtr id_createCompose_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/method[@name='createCompose' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("createCompose", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;ZI)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateCompose (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Bitmap p1, bool p2, int p3)
		{
			if (id_createCompose_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ZI == IntPtr.Zero)
				id_createCompose_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ZI = JNIEnv.GetStaticMethodID (class_ref, "createCompose", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;ZI)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCompose_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createTextImage_Ljava_lang_String_Landroid_graphics_Bitmap_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/method[@name='createTextImage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("createTextImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateTextImage (string p0, global::Android.Graphics.Bitmap p1, int p2, int p3)
		{
			if (id_createTextImage_Ljava_lang_String_Landroid_graphics_Bitmap_II == IntPtr.Zero)
				id_createTextImage_Ljava_lang_String_Landroid_graphics_Bitmap_II = JNIEnv.GetStaticMethodID (class_ref, "createTextImage", "(Ljava/lang/String;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTextImage_Ljava_lang_String_Landroid_graphics_Bitmap_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createWaterMask_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='ComposeTool']/method[@name='createWaterMask' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("createWaterMask", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateWaterMask (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Bitmap p1, int p2, int p3)
		{
			if (id_createWaterMask_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II == IntPtr.Zero)
				id_createWaterMask_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II = JNIEnv.GetStaticMethodID (class_ref, "createWaterMask", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWaterMask_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
