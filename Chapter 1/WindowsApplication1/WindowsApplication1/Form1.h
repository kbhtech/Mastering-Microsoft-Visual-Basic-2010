#pragma once

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
	internal: System::Windows::Forms::TextBox^  TextBox1;
	protected:
	internal: System::Windows::Forms::Label^  Label1;
	internal: System::Windows::Forms::Button^  bttnEvaluate;

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
			this->TextBox1 = (gcnew System::Windows::Forms::TextBox());
			this->Label1 = (gcnew System::Windows::Forms::Label());
			this->bttnEvaluate = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// TextBox1
			// 
			this->TextBox1->Location = System::Drawing::Point(11, 44);
			this->TextBox1->Margin = System::Windows::Forms::Padding(5, 4, 5, 4);
			this->TextBox1->Name = L"TextBox1";
			this->TextBox1->Size = System::Drawing::Size(268, 29);
			this->TextBox1->TabIndex = 8;
			// 
			// Label1
			// 
			this->Label1->AutoSize = true;
			this->Label1->Location = System::Drawing::Point(4, 8);
			this->Label1->Margin = System::Windows::Forms::Padding(5, 0, 5, 0);
			this->Label1->Name = L"Label1";
			this->Label1->Size = System::Drawing::Size(398, 22);
			this->Label1->TabIndex = 7;
			this->Label1->Text = L"Enter your favorite programming language";
			// 
			// bttnEvaluate
			// 
			this->bttnEvaluate->Location = System::Drawing::Point(4, 190);
			this->bttnEvaluate->Margin = System::Windows::Forms::Padding(5, 4, 5, 4);
			this->bttnEvaluate->Name = L"bttnEvaluate";
			this->bttnEvaluate->Size = System::Drawing::Size(275, 56);
			this->bttnEvaluate->TabIndex = 6;
			this->bttnEvaluate->Text = L"Evaluate My Choice";
			this->bttnEvaluate->UseVisualStyleBackColor = true;
			this->bttnEvaluate->Click += gcnew System::EventHandler(this, &Form1::bttnEvaluate_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(11, 22);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(287, 250);
			this->Controls->Add(this->TextBox1);
			this->Controls->Add(this->Label1);
			this->Controls->Add(this->bttnEvaluate);
			this->Font = (gcnew System::Drawing::Font(L"Verdana", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Margin = System::Windows::Forms::Padding(4, 3, 4, 3);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void bttnEvaluate_Click(System::Object^  sender, System::EventArgs^  e) {
		if (TextBox1->Text == "Visual C++") {
			MessageBox::Show("We have a winner!", "WindowsApplication1");
		}
		else {
			MessageBox::Show(TextBox1->Text + " is not a bad programming language.", "WindowsApplication1");
		}
	}

	};
}
