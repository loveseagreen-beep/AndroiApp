// Sử dụng thư viện System để có thể sử dụng Console
using System;

// Lớp chính của ứng dụng Console
public class Program
{
    // Phương thức Main - điểm khởi đầu của chương trình
    public static void Main(string[] args)
    {
        // Khai báo hằng số Pi
        const double PI = 3.14159;
        
        // Khai báo biến để lưu trữ bán kính và diện tích
        double radius = 0;
        double area = 0;

        Console.WriteLine("--- Tính Toán Diện Tích Hình Tròn ---");
        Console.WriteLine("Đây là logic C# để tính toán, có thể được dùng trong ứng dụng Android.");
        Console.WriteLine("--------------------------------------");

        // Yêu cầu người dùng nhập bán kính
        Console.Write("Vui lòng nhập giá trị bán kính (r): ");
        
        // Đọc giá trị và đảm bảo nó là một số hợp lệ
        try
        {
            // Đọc dòng nhập vào từ console
            string input = Console.ReadLine();
            
            // Chuyển đổi chuỗi nhập vào thành kiểu số thực (double)
            if (double.TryParse(input, out radius))
            {
                if (radius <= 0)
                {
                    Console.WriteLine("Lỗi: Bán kính phải là số dương.");
                    return;
                }

                // Tính toán diện tích: A = π * r * r
                area = PI * radius * radius;
                
                // Hiển thị kết quả ra màn hình
                Console.WriteLine($"\nBán kính đã nhập: {radius}");
                Console.WriteLine($"Hằng số Pi được sử dụng: {PI}");
                Console.WriteLine($"Diện tích hình tròn là: {area:F2}"); // :F2 format để làm tròn 2 chữ số thập phân
            }
            else
            {
                Console.WriteLine("Lỗi: Giá trị nhập vào không hợp lệ. Vui lòng nhập một số.");
            }
        }
        catch (Exception ex)
        {
            // Bắt lỗi nếu có sự cố xảy ra trong quá trình nhập/xử lý
            Console.WriteLine($"Đã xảy ra lỗi không mong muốn: {ex.Message}");
        }
    }
}
