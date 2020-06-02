public class MovingAverage {
    public List<int> data;
    /** Initialize your data structure here. */
    public MovingAverage(int size) {
        this.data = new List<int>(size){};
    }
    
    public double Next(int val) {
        if(isFull()){
            data.RemoveAt(0);
            data.Add(val);
        }else{
            data.Add(val);
        }
        return (double)data.Sum() / data.Count;
    }
    
    public bool isFull(){
        return data.Count == data.Capacity;
    }
}
