public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<EarthquakeFeature> Features { get; set; }

}

public class EarthquakeFeature
{
    public EarthquakeProperties Properties { get; set; }

}

public class EarthquakeProperties
{
    public string Place { get; set; }
    public decimal Mag { get; set; }
}
