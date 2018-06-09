
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Table table2;

	private global::Gtk.Button buttonSelectATK;

	private global::Gtk.Button buttonSelectDEF;

	private global::Gtk.Button buttonSelectHP;

	private global::Gtk.Button buttonSelectSPD;

	private global::Gtk.Button buttonSelectType;

	private global::Gtk.Label label1;

	private global::Gtk.Label label10;

	private global::Gtk.Label label2;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.Label label5;

	private global::Gtk.Label label6;

	private global::Gtk.Label label7;

	private global::Gtk.Label label8;

	private global::Gtk.Label label9;

	private global::Gtk.Label labelP1ATK;

	private global::Gtk.Label labelP1DEF;

	private global::Gtk.Label labelP1HP;

	private global::Gtk.Label labelP1SPD;

	private global::Gtk.Label labelP1Type;

	private global::Gtk.Label labelP2ATK;

	private global::Gtk.Label labelP2DEF;

	private global::Gtk.Label labelP2HP;

	private global::Gtk.Label labelP2SPD;

	private global::Gtk.Label labelP2Type;

	private global::Gtk.Image image1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.table2 = new global::Gtk.Table(((uint)(5)), ((uint)(6)), false);
		this.table2.WidthRequest = 464;
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectATK = new global::Gtk.Button();
		this.buttonSelectATK.CanFocus = true;
		this.buttonSelectATK.Name = "buttonSelectATK";
		this.buttonSelectATK.UseUnderline = true;
		this.buttonSelectATK.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectATK);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectATK]));
		w1.TopAttach = ((uint)(2));
		w1.BottomAttach = ((uint)(3));
		w1.LeftAttach = ((uint)(2));
		w1.RightAttach = ((uint)(3));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectDEF = new global::Gtk.Button();
		this.buttonSelectDEF.CanFocus = true;
		this.buttonSelectDEF.Name = "buttonSelectDEF";
		this.buttonSelectDEF.UseUnderline = true;
		this.buttonSelectDEF.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectDEF);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectDEF]));
		w2.TopAttach = ((uint)(3));
		w2.BottomAttach = ((uint)(4));
		w2.LeftAttach = ((uint)(2));
		w2.RightAttach = ((uint)(3));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectHP = new global::Gtk.Button();
		this.buttonSelectHP.CanFocus = true;
		this.buttonSelectHP.Name = "buttonSelectHP";
		this.buttonSelectHP.UseUnderline = true;
		this.buttonSelectHP.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectHP);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectHP]));
		w3.TopAttach = ((uint)(1));
		w3.BottomAttach = ((uint)(2));
		w3.LeftAttach = ((uint)(2));
		w3.RightAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectSPD = new global::Gtk.Button();
		this.buttonSelectSPD.CanFocus = true;
		this.buttonSelectSPD.Name = "buttonSelectSPD";
		this.buttonSelectSPD.UseUnderline = true;
		this.buttonSelectSPD.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectSPD);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectSPD]));
		w4.TopAttach = ((uint)(4));
		w4.BottomAttach = ((uint)(5));
		w4.LeftAttach = ((uint)(2));
		w4.RightAttach = ((uint)(3));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectType = new global::Gtk.Button();
		this.buttonSelectType.CanFocus = true;
		this.buttonSelectType.Name = "buttonSelectType";
		this.buttonSelectType.UseUnderline = true;
		this.buttonSelectType.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectType);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectType]));
		w5.LeftAttach = ((uint)(2));
		w5.RightAttach = ((uint)(3));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Type");
		this.table2.Add(this.label1);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.label1]));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label10 = new global::Gtk.Label();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("SPD");
		this.table2.Add(this.label10);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.label10]));
		w7.TopAttach = ((uint)(4));
		w7.BottomAttach = ((uint)(5));
		w7.LeftAttach = ((uint)(4));
		w7.RightAttach = ((uint)(5));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("HP");
		this.table2.Add(this.label2);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.label2]));
		w8.TopAttach = ((uint)(1));
		w8.BottomAttach = ((uint)(2));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("ATK");
		this.table2.Add(this.label3);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
		w9.TopAttach = ((uint)(2));
		w9.BottomAttach = ((uint)(3));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("DEF");
		this.table2.Add(this.label4);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
		w10.TopAttach = ((uint)(3));
		w10.BottomAttach = ((uint)(4));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("SPD");
		this.table2.Add(this.label5);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
		w11.TopAttach = ((uint)(4));
		w11.BottomAttach = ((uint)(5));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Type");
		this.table2.Add(this.label6);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.label6]));
		w12.LeftAttach = ((uint)(4));
		w12.RightAttach = ((uint)(5));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("HP");
		this.table2.Add(this.label7);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
		w13.TopAttach = ((uint)(1));
		w13.BottomAttach = ((uint)(2));
		w13.LeftAttach = ((uint)(4));
		w13.RightAttach = ((uint)(5));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("ATK");
		this.table2.Add(this.label8);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2[this.label8]));
		w14.TopAttach = ((uint)(2));
		w14.BottomAttach = ((uint)(3));
		w14.LeftAttach = ((uint)(4));
		w14.RightAttach = ((uint)(5));
		w14.XOptions = ((global::Gtk.AttachOptions)(4));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("DEF");
		this.table2.Add(this.label9);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2[this.label9]));
		w15.TopAttach = ((uint)(3));
		w15.BottomAttach = ((uint)(4));
		w15.LeftAttach = ((uint)(4));
		w15.RightAttach = ((uint)(5));
		w15.XOptions = ((global::Gtk.AttachOptions)(4));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1ATK = new global::Gtk.Label();
		this.labelP1ATK.Name = "labelP1ATK";
		this.labelP1ATK.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1ATK);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1ATK]));
		w16.TopAttach = ((uint)(2));
		w16.BottomAttach = ((uint)(3));
		w16.LeftAttach = ((uint)(1));
		w16.RightAttach = ((uint)(2));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1DEF = new global::Gtk.Label();
		this.labelP1DEF.Name = "labelP1DEF";
		this.labelP1DEF.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1DEF);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1DEF]));
		w17.TopAttach = ((uint)(3));
		w17.BottomAttach = ((uint)(4));
		w17.LeftAttach = ((uint)(1));
		w17.RightAttach = ((uint)(2));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1HP = new global::Gtk.Label();
		this.labelP1HP.Name = "labelP1HP";
		this.labelP1HP.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1HP);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1HP]));
		w18.TopAttach = ((uint)(1));
		w18.BottomAttach = ((uint)(2));
		w18.LeftAttach = ((uint)(1));
		w18.RightAttach = ((uint)(2));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1SPD = new global::Gtk.Label();
		this.labelP1SPD.Name = "labelP1SPD";
		this.labelP1SPD.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1SPD);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1SPD]));
		w19.TopAttach = ((uint)(4));
		w19.BottomAttach = ((uint)(5));
		w19.LeftAttach = ((uint)(1));
		w19.RightAttach = ((uint)(2));
		w19.XOptions = ((global::Gtk.AttachOptions)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1Type = new global::Gtk.Label();
		this.labelP1Type.WidthRequest = 78;
		this.labelP1Type.Name = "labelP1Type";
		this.labelP1Type.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1Type);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1Type]));
		w20.LeftAttach = ((uint)(1));
		w20.RightAttach = ((uint)(2));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2ATK = new global::Gtk.Label();
		this.labelP2ATK.Name = "labelP2ATK";
		this.labelP2ATK.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2ATK);
		global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2ATK]));
		w21.TopAttach = ((uint)(2));
		w21.BottomAttach = ((uint)(3));
		w21.LeftAttach = ((uint)(5));
		w21.RightAttach = ((uint)(6));
		w21.XOptions = ((global::Gtk.AttachOptions)(4));
		w21.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2DEF = new global::Gtk.Label();
		this.labelP2DEF.Name = "labelP2DEF";
		this.labelP2DEF.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2DEF);
		global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2DEF]));
		w22.TopAttach = ((uint)(3));
		w22.BottomAttach = ((uint)(4));
		w22.LeftAttach = ((uint)(5));
		w22.RightAttach = ((uint)(6));
		w22.XOptions = ((global::Gtk.AttachOptions)(4));
		w22.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2HP = new global::Gtk.Label();
		this.labelP2HP.Name = "labelP2HP";
		this.labelP2HP.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2HP);
		global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2HP]));
		w23.TopAttach = ((uint)(1));
		w23.BottomAttach = ((uint)(2));
		w23.LeftAttach = ((uint)(5));
		w23.RightAttach = ((uint)(6));
		w23.XOptions = ((global::Gtk.AttachOptions)(4));
		w23.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2SPD = new global::Gtk.Label();
		this.labelP2SPD.Name = "labelP2SPD";
		this.labelP2SPD.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2SPD);
		global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2SPD]));
		w24.TopAttach = ((uint)(4));
		w24.BottomAttach = ((uint)(5));
		w24.LeftAttach = ((uint)(5));
		w24.RightAttach = ((uint)(6));
		w24.XOptions = ((global::Gtk.AttachOptions)(4));
		w24.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2Type = new global::Gtk.Label();
		this.labelP2Type.WidthRequest = 78;
		this.labelP2Type.Name = "labelP2Type";
		this.labelP2Type.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2Type);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2Type]));
		w25.LeftAttach = ((uint)(5));
		w25.RightAttach = ((uint)(6));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		this.fixed1.Add(this.table2);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.table2]));
		w26.X = 208;
		w26.Y = 116;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.image1 = new global::Gtk.Image();
		this.image1.Name = "image1";
		this.fixed1.Add(this.image1);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image1]));
		w27.X = 75;
		w27.Y = 159;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 981;
		this.DefaultHeight = 526;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
