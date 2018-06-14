
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox3;

	private global::Gtk.VBox vbox6;

	private global::Gtk.Table table4;

	private global::Gtk.HSeparator hseparator10;

	private global::Gtk.HSeparator hseparator15;

	private global::Gtk.HSeparator hseparator17;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label labelP1Name;

	private global::Gtk.Label labelSpacer1;

	private global::Gtk.Label labelP2Name;

	private global::Gtk.HBox hbox1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Label labelP1CardName;

	private global::Gtk.Image imageP1;

	private global::Gtk.Label labelP1FlavourText;

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

	private global::Gtk.Label labelSpacer;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label labelP2CardName;

	private global::Gtk.Image imageP2;

	private global::Gtk.Label labelP2FlavourText;

	private global::Gtk.Label labelTurnResult;

	private global::Gtk.Table table3;

	private global::Gtk.Button buttonNextCard;

	private global::Gtk.HSeparator hseparator2;

	private global::Gtk.HSeparator hseparator3;

	private global::Gtk.HSeparator hseparator8;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.HBox hbox4;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label label11;

	private global::Gtk.Label labelP1CardCount;

	private global::Gtk.Image imageDeck1;

	private global::Gtk.VBox vbox7;

	private global::Gtk.Label label13;

	private global::Gtk.Label labelTieCardCount;

	private global::Gtk.Image imageDeck3;

	private global::Gtk.VBox vbox5;

	private global::Gtk.Label label12;

	private global::Gtk.Label labelP2CardCount;

	private global::Gtk.Image imageDeck2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 10;
		this.vbox3.BorderWidth = ((uint)(30));
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.table4 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(6));
		// Container child table4.Gtk.Table+TableChild
		this.hseparator10 = new global::Gtk.HSeparator();
		this.hseparator10.Name = "hseparator10";
		this.table4.Add(this.hseparator10);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table4[this.hseparator10]));
		w1.LeftAttach = ((uint)(2));
		w1.RightAttach = ((uint)(3));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.hseparator15 = new global::Gtk.HSeparator();
		this.hseparator15.Name = "hseparator15";
		this.table4.Add(this.hseparator15);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table4[this.hseparator15]));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.hseparator17 = new global::Gtk.HSeparator();
		this.hseparator17.Name = "hseparator17";
		this.table4.Add(this.hseparator17);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4[this.hseparator17]));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox6.Add(this.table4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.table4]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox3.Add(this.vbox6);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vbox6]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.labelP1Name = new global::Gtk.Label();
		this.labelP1Name.Name = "labelP1Name";
		this.labelP1Name.Xalign = 0F;
		this.labelP1Name.LabelProp = global::Mono.Unix.Catalog.GetString("Player 1");
		this.labelP1Name.UseMarkup = true;
		this.labelP1Name.UseUnderline = true;
		this.hbox2.Add(this.labelP1Name);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelP1Name]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		w6.Padding = ((uint)(8));
		// Container child hbox2.Gtk.Box+BoxChild
		this.labelSpacer1 = new global::Gtk.Label();
		this.labelSpacer1.Name = "labelSpacer1";
		this.labelSpacer1.Justify = ((global::Gtk.Justification)(2));
		this.hbox2.Add(this.labelSpacer1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelSpacer1]));
		w7.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.labelP2Name = new global::Gtk.Label();
		this.labelP2Name.Name = "labelP2Name";
		this.labelP2Name.Xalign = 1F;
		this.labelP2Name.LabelProp = global::Mono.Unix.Catalog.GetString("Player 2");
		this.labelP2Name.UseMarkup = true;
		this.labelP2Name.UseUnderline = true;
		this.labelP2Name.Justify = ((global::Gtk.Justification)(1));
		this.labelP2Name.Selectable = true;
		this.hbox2.Add(this.labelP2Name);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelP2Name]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		w8.Padding = ((uint)(8));
		this.vbox3.Add(this.hbox2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.HeightRequest = 256;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelP1CardName = new global::Gtk.Label();
		this.labelP1CardName.Name = "labelP1CardName";
		this.labelP1CardName.LabelProp = global::Mono.Unix.Catalog.GetString("Card Name");
		this.labelP1CardName.Justify = ((global::Gtk.Justification)(2));
		this.vbox1.Add(this.labelP1CardName);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelP1CardName]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		w10.Padding = ((uint)(5));
		// Container child vbox1.Gtk.Box+BoxChild
		this.imageP1 = new global::Gtk.Image();
		this.imageP1.WidthRequest = 128;
		this.imageP1.HeightRequest = 128;
		this.imageP1.Name = "imageP1";
		this.vbox1.Add(this.imageP1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.imageP1]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelP1FlavourText = new global::Gtk.Label();
		this.labelP1FlavourText.WidthRequest = 128;
		this.labelP1FlavourText.Name = "labelP1FlavourText";
		this.labelP1FlavourText.LabelProp = global::Mono.Unix.Catalog.GetString("Lorem ipsum dolor sit amet, inermis nominavi patrioque eos ut, ei putent volutpat" +
				" ocurreret sit.");
		this.labelP1FlavourText.UseMarkup = true;
		this.labelP1FlavourText.Wrap = true;
		this.labelP1FlavourText.Justify = ((global::Gtk.Justification)(2));
		this.vbox1.Add(this.labelP1FlavourText);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelP1FlavourText]));
		w12.Position = 2;
		this.hbox1.Add(this.vbox1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.table2 = new global::Gtk.Table(((uint)(7)), ((uint)(6)), false);
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
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectATK]));
		w14.TopAttach = ((uint)(3));
		w14.BottomAttach = ((uint)(4));
		w14.LeftAttach = ((uint)(2));
		w14.RightAttach = ((uint)(3));
		w14.XOptions = ((global::Gtk.AttachOptions)(4));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectDEF = new global::Gtk.Button();
		this.buttonSelectDEF.CanFocus = true;
		this.buttonSelectDEF.Name = "buttonSelectDEF";
		this.buttonSelectDEF.UseUnderline = true;
		this.buttonSelectDEF.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectDEF);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectDEF]));
		w15.TopAttach = ((uint)(4));
		w15.BottomAttach = ((uint)(5));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		w15.XOptions = ((global::Gtk.AttachOptions)(4));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectHP = new global::Gtk.Button();
		this.buttonSelectHP.CanFocus = true;
		this.buttonSelectHP.Name = "buttonSelectHP";
		this.buttonSelectHP.UseUnderline = true;
		this.buttonSelectHP.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectHP);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectHP]));
		w16.TopAttach = ((uint)(2));
		w16.BottomAttach = ((uint)(3));
		w16.LeftAttach = ((uint)(2));
		w16.RightAttach = ((uint)(3));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectSPD = new global::Gtk.Button();
		this.buttonSelectSPD.CanFocus = true;
		this.buttonSelectSPD.Name = "buttonSelectSPD";
		this.buttonSelectSPD.UseUnderline = true;
		this.buttonSelectSPD.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectSPD);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectSPD]));
		w17.TopAttach = ((uint)(5));
		w17.BottomAttach = ((uint)(6));
		w17.LeftAttach = ((uint)(2));
		w17.RightAttach = ((uint)(3));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonSelectType = new global::Gtk.Button();
		this.buttonSelectType.CanFocus = true;
		this.buttonSelectType.Name = "buttonSelectType";
		this.buttonSelectType.UseUnderline = true;
		this.buttonSelectType.Label = global::Mono.Unix.Catalog.GetString("Select Discipline");
		this.table2.Add(this.buttonSelectType);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonSelectType]));
		w18.TopAttach = ((uint)(1));
		w18.BottomAttach = ((uint)(2));
		w18.LeftAttach = ((uint)(2));
		w18.RightAttach = ((uint)(3));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Type");
		this.table2.Add(this.label1);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.label1]));
		w19.TopAttach = ((uint)(1));
		w19.BottomAttach = ((uint)(2));
		w19.XOptions = ((global::Gtk.AttachOptions)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label10 = new global::Gtk.Label();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Speed");
		this.table2.Add(this.label10);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.label10]));
		w20.TopAttach = ((uint)(5));
		w20.BottomAttach = ((uint)(6));
		w20.LeftAttach = ((uint)(4));
		w20.RightAttach = ((uint)(5));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Health Points");
		this.table2.Add(this.label2);
		global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.label2]));
		w21.TopAttach = ((uint)(2));
		w21.BottomAttach = ((uint)(3));
		w21.XOptions = ((global::Gtk.AttachOptions)(4));
		w21.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Attack");
		this.table2.Add(this.label3);
		global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
		w22.TopAttach = ((uint)(3));
		w22.BottomAttach = ((uint)(4));
		w22.XOptions = ((global::Gtk.AttachOptions)(4));
		w22.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Defence");
		this.table2.Add(this.label4);
		global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
		w23.TopAttach = ((uint)(4));
		w23.BottomAttach = ((uint)(5));
		w23.XOptions = ((global::Gtk.AttachOptions)(4));
		w23.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Speed");
		this.table2.Add(this.label5);
		global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
		w24.TopAttach = ((uint)(5));
		w24.BottomAttach = ((uint)(6));
		w24.XOptions = ((global::Gtk.AttachOptions)(4));
		w24.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Type");
		this.table2.Add(this.label6);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2[this.label6]));
		w25.TopAttach = ((uint)(1));
		w25.BottomAttach = ((uint)(2));
		w25.LeftAttach = ((uint)(4));
		w25.RightAttach = ((uint)(5));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Health Points");
		this.table2.Add(this.label7);
		global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
		w26.TopAttach = ((uint)(2));
		w26.BottomAttach = ((uint)(3));
		w26.LeftAttach = ((uint)(4));
		w26.RightAttach = ((uint)(5));
		w26.XOptions = ((global::Gtk.AttachOptions)(4));
		w26.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Attack");
		this.table2.Add(this.label8);
		global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2[this.label8]));
		w27.TopAttach = ((uint)(3));
		w27.BottomAttach = ((uint)(4));
		w27.LeftAttach = ((uint)(4));
		w27.RightAttach = ((uint)(5));
		w27.XOptions = ((global::Gtk.AttachOptions)(4));
		w27.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Defence");
		this.table2.Add(this.label9);
		global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2[this.label9]));
		w28.TopAttach = ((uint)(4));
		w28.BottomAttach = ((uint)(5));
		w28.LeftAttach = ((uint)(4));
		w28.RightAttach = ((uint)(5));
		w28.XOptions = ((global::Gtk.AttachOptions)(4));
		w28.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1ATK = new global::Gtk.Label();
		this.labelP1ATK.Name = "labelP1ATK";
		this.labelP1ATK.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1ATK);
		global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1ATK]));
		w29.TopAttach = ((uint)(3));
		w29.BottomAttach = ((uint)(4));
		w29.LeftAttach = ((uint)(1));
		w29.RightAttach = ((uint)(2));
		w29.XOptions = ((global::Gtk.AttachOptions)(4));
		w29.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1DEF = new global::Gtk.Label();
		this.labelP1DEF.Name = "labelP1DEF";
		this.labelP1DEF.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1DEF);
		global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1DEF]));
		w30.TopAttach = ((uint)(4));
		w30.BottomAttach = ((uint)(5));
		w30.LeftAttach = ((uint)(1));
		w30.RightAttach = ((uint)(2));
		w30.XOptions = ((global::Gtk.AttachOptions)(4));
		w30.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1HP = new global::Gtk.Label();
		this.labelP1HP.Name = "labelP1HP";
		this.labelP1HP.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1HP);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1HP]));
		w31.TopAttach = ((uint)(2));
		w31.BottomAttach = ((uint)(3));
		w31.LeftAttach = ((uint)(1));
		w31.RightAttach = ((uint)(2));
		w31.XOptions = ((global::Gtk.AttachOptions)(4));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1SPD = new global::Gtk.Label();
		this.labelP1SPD.Name = "labelP1SPD";
		this.labelP1SPD.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1SPD);
		global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1SPD]));
		w32.TopAttach = ((uint)(5));
		w32.BottomAttach = ((uint)(6));
		w32.LeftAttach = ((uint)(1));
		w32.RightAttach = ((uint)(2));
		w32.XOptions = ((global::Gtk.AttachOptions)(4));
		w32.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP1Type = new global::Gtk.Label();
		this.labelP1Type.WidthRequest = 78;
		this.labelP1Type.Name = "labelP1Type";
		this.labelP1Type.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP1Type);
		global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP1Type]));
		w33.TopAttach = ((uint)(1));
		w33.BottomAttach = ((uint)(2));
		w33.LeftAttach = ((uint)(1));
		w33.RightAttach = ((uint)(2));
		w33.XOptions = ((global::Gtk.AttachOptions)(4));
		w33.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2ATK = new global::Gtk.Label();
		this.labelP2ATK.Name = "labelP2ATK";
		this.labelP2ATK.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2ATK);
		global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2ATK]));
		w34.TopAttach = ((uint)(3));
		w34.BottomAttach = ((uint)(4));
		w34.LeftAttach = ((uint)(5));
		w34.RightAttach = ((uint)(6));
		w34.XOptions = ((global::Gtk.AttachOptions)(4));
		w34.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2DEF = new global::Gtk.Label();
		this.labelP2DEF.Name = "labelP2DEF";
		this.labelP2DEF.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2DEF);
		global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2DEF]));
		w35.TopAttach = ((uint)(4));
		w35.BottomAttach = ((uint)(5));
		w35.LeftAttach = ((uint)(5));
		w35.RightAttach = ((uint)(6));
		w35.XOptions = ((global::Gtk.AttachOptions)(4));
		w35.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2HP = new global::Gtk.Label();
		this.labelP2HP.Name = "labelP2HP";
		this.labelP2HP.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2HP);
		global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2HP]));
		w36.TopAttach = ((uint)(2));
		w36.BottomAttach = ((uint)(3));
		w36.LeftAttach = ((uint)(5));
		w36.RightAttach = ((uint)(6));
		w36.XOptions = ((global::Gtk.AttachOptions)(4));
		w36.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2SPD = new global::Gtk.Label();
		this.labelP2SPD.Name = "labelP2SPD";
		this.labelP2SPD.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2SPD);
		global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2SPD]));
		w37.TopAttach = ((uint)(5));
		w37.BottomAttach = ((uint)(6));
		w37.LeftAttach = ((uint)(5));
		w37.RightAttach = ((uint)(6));
		w37.XOptions = ((global::Gtk.AttachOptions)(4));
		w37.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelP2Type = new global::Gtk.Label();
		this.labelP2Type.WidthRequest = 78;
		this.labelP2Type.Name = "labelP2Type";
		this.labelP2Type.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.table2.Add(this.labelP2Type);
		global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table2[this.labelP2Type]));
		w38.TopAttach = ((uint)(1));
		w38.BottomAttach = ((uint)(2));
		w38.LeftAttach = ((uint)(5));
		w38.RightAttach = ((uint)(6));
		w38.XOptions = ((global::Gtk.AttachOptions)(4));
		w38.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.labelSpacer = new global::Gtk.Label();
		this.labelSpacer.Name = "labelSpacer";
		this.table2.Add(this.labelSpacer);
		global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table2[this.labelSpacer]));
		w39.LeftAttach = ((uint)(3));
		w39.RightAttach = ((uint)(4));
		w39.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox1.Add(this.table2);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table2]));
		w40.Position = 1;
		w40.Padding = ((uint)(15));
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.HeightRequest = 256;
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelP2CardName = new global::Gtk.Label();
		this.labelP2CardName.Name = "labelP2CardName";
		this.labelP2CardName.LabelProp = global::Mono.Unix.Catalog.GetString("Card Name");
		this.labelP2CardName.Justify = ((global::Gtk.Justification)(2));
		this.vbox2.Add(this.labelP2CardName);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelP2CardName]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		w41.Padding = ((uint)(5));
		// Container child vbox2.Gtk.Box+BoxChild
		this.imageP2 = new global::Gtk.Image();
		this.imageP2.WidthRequest = 128;
		this.imageP2.HeightRequest = 128;
		this.imageP2.Name = "imageP2";
		this.vbox2.Add(this.imageP2);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.imageP2]));
		w42.Position = 1;
		w42.Expand = false;
		w42.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelP2FlavourText = new global::Gtk.Label();
		this.labelP2FlavourText.WidthRequest = 128;
		this.labelP2FlavourText.Name = "labelP2FlavourText";
		this.labelP2FlavourText.LabelProp = global::Mono.Unix.Catalog.GetString("Lorem ipsum dolor sit amet, inermis nominavi patrioque eos ut, ei putent volutpat" +
				" ocurreret sit.");
		this.labelP2FlavourText.UseMarkup = true;
		this.labelP2FlavourText.Wrap = true;
		this.labelP2FlavourText.Justify = ((global::Gtk.Justification)(2));
		this.vbox2.Add(this.labelP2FlavourText);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelP2FlavourText]));
		w43.Position = 2;
		this.hbox1.Add(this.vbox2);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
		w44.Position = 2;
		w44.Expand = false;
		w44.Fill = false;
		this.vbox3.Add(this.hbox1);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
		w45.Position = 2;
		w45.Expand = false;
		w45.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.labelTurnResult = new global::Gtk.Label();
		this.labelTurnResult.Name = "labelTurnResult";
		this.labelTurnResult.LabelProp = global::Mono.Unix.Catalog.GetString("<Player 1> wins the turn.");
		this.labelTurnResult.UseMarkup = true;
		this.vbox3.Add(this.labelTurnResult);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.labelTurnResult]));
		w46.Position = 3;
		w46.Expand = false;
		w46.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.buttonNextCard = new global::Gtk.Button();
		this.buttonNextCard.CanFocus = true;
		this.buttonNextCard.Name = "buttonNextCard";
		this.buttonNextCard.UseUnderline = true;
		this.buttonNextCard.Label = global::Mono.Unix.Catalog.GetString("Next Card");
		this.table3.Add(this.buttonNextCard);
		global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table3[this.buttonNextCard]));
		w47.LeftAttach = ((uint)(1));
		w47.RightAttach = ((uint)(2));
		w47.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.hseparator2 = new global::Gtk.HSeparator();
		this.hseparator2.Name = "hseparator2";
		this.table3.Add(this.hseparator2);
		global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table3[this.hseparator2]));
		w48.XOptions = ((global::Gtk.AttachOptions)(1));
		w48.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.hseparator3 = new global::Gtk.HSeparator();
		this.hseparator3.Name = "hseparator3";
		this.table3.Add(this.hseparator3);
		global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table3[this.hseparator3]));
		w49.LeftAttach = ((uint)(2));
		w49.RightAttach = ((uint)(3));
		w49.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.hseparator8 = new global::Gtk.HSeparator();
		this.hseparator8.Name = "hseparator8";
		this.table3.Add(this.hseparator8);
		global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table3[this.hseparator8]));
		w50.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox3.Add(this.table3);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table3]));
		w51.Position = 4;
		w51.Expand = false;
		w51.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.Name = "hseparator1";
		this.vbox3.Add(this.hseparator1);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
		w52.Position = 5;
		w52.Expand = false;
		w52.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label11 = new global::Gtk.Label();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Cards in Deck:");
		this.vbox4.Add(this.label11);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label11]));
		w53.Position = 0;
		w53.Expand = false;
		w53.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.labelP1CardCount = new global::Gtk.Label();
		this.labelP1CardCount.Name = "labelP1CardCount";
		this.labelP1CardCount.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.vbox4.Add(this.labelP1CardCount);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.labelP1CardCount]));
		w54.Position = 1;
		w54.Expand = false;
		w54.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.imageDeck1 = new global::Gtk.Image();
		this.imageDeck1.Name = "imageDeck1";
		this.vbox4.Add(this.imageDeck1);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.imageDeck1]));
		w55.Position = 2;
		w55.Expand = false;
		w55.Fill = false;
		this.hbox4.Add(this.vbox4);
		global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
		w56.Position = 0;
		w56.Expand = false;
		w56.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.label13 = new global::Gtk.Label();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Tie Cards");
		this.vbox7.Add(this.label13);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label13]));
		w57.Position = 0;
		w57.Expand = false;
		w57.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.labelTieCardCount = new global::Gtk.Label();
		this.labelTieCardCount.Name = "labelTieCardCount";
		this.labelTieCardCount.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.vbox7.Add(this.labelTieCardCount);
		global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.labelTieCardCount]));
		w58.Position = 1;
		w58.Expand = false;
		w58.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.imageDeck3 = new global::Gtk.Image();
		this.imageDeck3.Name = "imageDeck3";
		this.vbox7.Add(this.imageDeck3);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.imageDeck3]));
		w59.Position = 2;
		w59.Expand = false;
		w59.Fill = false;
		this.hbox4.Add(this.vbox7);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox7]));
		w60.Position = 2;
		w60.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label12 = new global::Gtk.Label();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Cards in Deck:");
		this.vbox5.Add(this.label12);
		global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label12]));
		w61.Position = 0;
		w61.Expand = false;
		w61.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.labelP2CardCount = new global::Gtk.Label();
		this.labelP2CardCount.Name = "labelP2CardCount";
		this.labelP2CardCount.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.vbox5.Add(this.labelP2CardCount);
		global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.labelP2CardCount]));
		w62.Position = 1;
		w62.Expand = false;
		w62.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.imageDeck2 = new global::Gtk.Image();
		this.imageDeck2.Name = "imageDeck2";
		this.vbox5.Add(this.imageDeck2);
		global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.imageDeck2]));
		w63.Position = 2;
		w63.Expand = false;
		w63.Fill = false;
		this.hbox4.Add(this.vbox5);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox5]));
		w64.Position = 4;
		w64.Expand = false;
		w64.Fill = false;
		this.vbox3.Add(this.hbox4);
		global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
		w65.Position = 6;
		w65.Expand = false;
		w65.Fill = false;
		this.Add(this.vbox3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 960;
		this.DefaultHeight = 572;
		this.Show();
		this.buttonSelectType.Clicked += new global::System.EventHandler(this.TypeDisciplineSelected);
		this.buttonSelectSPD.Clicked += new global::System.EventHandler(this.SPDDisciplineSelected);
		this.buttonSelectHP.Clicked += new global::System.EventHandler(this.HPDisciplineSelected);
		this.buttonSelectDEF.Clicked += new global::System.EventHandler(this.DEFDisciplineSelected);
		this.buttonSelectATK.Clicked += new global::System.EventHandler(this.ATKDisciplineSelected);
		this.buttonNextCard.Clicked += new global::System.EventHandler(this.NextCardClicked);
	}
}
