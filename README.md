# LeetCode Solutions bằng C#

Repository này được tạo để lưu trữ các bài tập LeetCode mà tôi đã giải bằng `C#` trên nền tảng `.NET`. Mục tiêu chính là xây dựng một nơi tập trung để theo dõi quá trình học, rèn luyện tư duy thuật toán, ôn tập cấu trúc dữ liệu, và lưu lại các lời giải đã làm để có thể xem lại bất cứ lúc nào.

## Mục Tiêu Của Repository

- Lưu trữ các lời giải LeetCode đã hoàn thành bằng `C#`.
- Rèn luyện tư duy giải quyết vấn đề thông qua các nhóm chủ đề như `Array`, `String`, `Greedy`, `Dynamic Programming`, `Graph`, `Tree`, `Binary Search`, ...
- Giữ lại lịch sử học tập và tiến độ giải bài theo thời gian.
- Tạo một bộ sưu tập code để xem lại khi ôn tập phỏng vấn hoặc học nâng cao hơn về thuật toán.

## Công Nghệ Sử Dụng

- Ngôn ngữ: `C#`
- Nền tảng: `.NET 10`
- Kiểu project: `Class Library`

File cấu hình project hiện tại:

- `Leetcode.csproj`

Một số cấu hình đang được sử dụng:

- `TargetFramework`: `net10.0`
- `ImplicitUsings`: `enable`
- `Nullable`: `enable`

## Cấu Trúc Repository

```text
Leetcode/
|-- Problems/
|   `-- Problem757.cs
|-- Leetcode.csproj
|-- Leetcode.slnx
|-- README.md
`-- .gitignore
```

### Ý Nghĩa Từng Thành Phần

- `Problems/`: Chứa các file lời giải cho từng bài LeetCode.
- `Problem757.cs`: Lời giải cho bài `757. Set Intersection Size At Least Two`.
- `Leetcode.csproj`: File cấu hình project `.NET`.
- `Leetcode.slnx`: File solution của repository.
- `.gitignore`: Bỏ qua các file sinh ra trong quá trình build và các tệp tạm.

## Cách Tổ Chức Lời Giải

Repository hiện tại đang tổ chức mỗi bài giải trong một file riêng theo quy ước:

- `Problem<SoBai>.cs`

Ví dụ:

- `Problem757.cs`

Bên trong các file, lời giải được đặt trong `namespace Leetcode.Problems` và sử dụng `partial class Solution`. Cách tổ chức này giúp:

- Giữ giao diện giải bài tương tự như trên LeetCode.
- Tách từng bài thành nhiều file độc lập để dễ quản lý.
- Mở rộng repository về sau mà không cần thay đổi cấu trúc tổng thể.

## Các Bài Đã Có Hiện Tại

| LeetCode ID | Tên bài | File | Hướng tiếp cận |
|---|---|---|---|
| 757 | Set Intersection Size At Least Two | `Problems/Problem757.cs` | Greedy + Sorting |

## Cách Build Project

Để build repository này, chạy lệnh:

```powershell
dotnet build Leetcode.csproj
```

Lệnh trên đã được kiểm tra và build thành công trong trạng thái hiện tại của repository.

## Cách Thêm Bài Mới

Khi giải một bài mới, có thể thêm theo quy trình sau:

1. Tạo file mới trong thư mục `Problems`.
2. Đặt tên theo quy ước `Problem<SoBai>.cs`.
3. Thêm namespace `Leetcode.Problems`.
4. Cài đặt method tương ứng theo đề bài LeetCode.

Mẫu cơ bản:

```csharp
namespace Leetcode.Problems;

public partial class Solution
{
    public ReturnType MethodName(ParameterType input)
    {
        // Solution here
    }
}
```

## Định Hướng Phát Triển

Về sau, repository có thể mở rộng theo nhiều hướng:

- Thêm nhãn chủ đề cho từng bài như `Array`, `DP`, `Graph`, `Greedy`.
- Bổ sung ghi chú ngắn cho mỗi bài: ý tưởng, độ khó, điểm cần chú ý.
- Tạo bảng thống kê tổng số bài đã giải.
- Bổ sung thư mục ghi chú học tập hoặc tổng hợp mẫu giải thường gặp.

## Mục Đích Học Tập

Repository này không chỉ là nơi lưu code, mà còn là nhật ký học tập cá nhân trong quá trình rèn luyện:

- khả năng đọc đề,
- phân tích ràng buộc,
- lựa chọn cấu trúc dữ liệu phù hợp,
- tối ưu độ phức tạp thời gian và bộ nhớ,
- và xây dựng phong cách code rõ ràng hơn trong `C#`.

## Ghi Chú

- Repository hiện đang tập trung vào các bài đã làm bằng `C# (.NET)`.
- Cấu trúc hiện tại phù hợp để tiếp tục mở rộng khi số lượng bài tăng lên.
- Nếu cần, có thể bổ sung `tests`, `notes`, hoặc bảng phân loại bài tập trong các lần cập nhật tiếp theo.
