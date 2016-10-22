#pragma once
#include <string>

namespace WindowsApplication1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:
	internal: System::Windows::Forms::Label^  Label1;
	internal: System::Windows::Forms::Button^  bttnEvaluate;
	private: System::Windows::Forms::ComboBox^  comboBox1;
	internal:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->Label1 = (gcnew System::Windows::Forms::Label());
			this->bttnEvaluate = (gcnew System::Windows::Forms::Button());
			this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->SuspendLayout();
			// 
			// Label1
			// 
			this->Label1->AutoSize = true;
			this->Label1->Location = System::Drawing::Point(7, 14);
			this->Label1->Margin = System::Windows::Forms::Padding(5, 0, 5, 0);
			this->Label1->Name = L"Label1";
			this->Label1->Size = System::Drawing::Size(398, 22);
			this->Label1->TabIndex = 7;
			this->Label1->Text = L"Enter your favorite programming language";
			// 
			// bttnEvaluate
			// 
			this->bttnEvaluate->Location = System::Drawing::Point(7, 210);
			this->bttnEvaluate->Margin = System::Windows::Forms::Padding(5, 4, 5, 4);
			this->bttnEvaluate->Name = L"bttnEvaluate";
			this->bttnEvaluate->Size = System::Drawing::Size(275, 60);
			this->bttnEvaluate->TabIndex = 6;
			this->bttnEvaluate->Text = L"Evaluate My Choice";
			this->bttnEvaluate->UseVisualStyleBackColor = true;
			this->bttnEvaluate->Click += gcnew System::EventHandler(this, &Form1::bttnEvaluate_Click);
			// 
			// comboBox1
			// 
			this->comboBox1->FormattingEnabled = true;
			this->comboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(5) { L"C++", L"C#", L"Visual Basic", L"Java", L"Cobol" });
			this->comboBox1->Location = System::Drawing::Point(13, 42);
			this->comboBox1->Name = L"comboBox1";
			this->comboBox1->Size = System::Drawing::Size(268, 30);
			this->comboBox1->TabIndex = 8;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(11, 22);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(289, 284);
			this->Controls->Add(this->comboBox1);
			this->Controls->Add(this->Label1);
			this->Controls->Add(this->bttnEvaluate);
			this->Font = (gcnew System::Drawing::Font(L"Verdana", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Margin = System::Windows::Forms::Padding(4, 3, 4, 3);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void bttnEvaluate_Click(System::Object^  sender, System::EventArgs^  e) {
		if (comboBox1->Text == "C++") {
			MessageBox::Show("We have a winner!", "WindowsApplication2");
		}
		else {
			MessageBox::Show(comboBox1->Text + " is not a bad programming language.", "WindowsApplication1");
		}
	}

	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
		comboBox1->SelectedIndex = 0;
	}
};
}
