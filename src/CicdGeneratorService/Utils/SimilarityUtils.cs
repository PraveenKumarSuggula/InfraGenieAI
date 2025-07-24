namespace CicdGeneratorService.Utils
{
    public static class SimilarityUtils
    {
        public static double CosineSimilarity(float[] v1, float[] v2)
        {
            float dot = 0, normA = 0, normB = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                dot += v1[i] * v2[i];
                normA += v1[i] * v1[i];
                normB += v2[i] * v2[i];
            }
            return dot / (Math.Sqrt(normA) * Math.Sqrt(normB));
        }
    }
}
