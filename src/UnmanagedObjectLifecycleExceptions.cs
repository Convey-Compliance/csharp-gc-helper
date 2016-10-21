using System;

namespace GChelpers
{
  [Serializable]
  public class EDisposeHelper : Exception
  {
    public EDisposeHelper() { }

    public EDisposeHelper(string msg) : base(msg) { }
  }

  [Serializable]
  public class EObjectNotFound<THandleType> : EDisposeHelper
  {
    public EObjectNotFound(THandleType obj) : base(string.Format("Object not found ({0})", obj)) { }
  }

  [Serializable]
  public class EDependencyObjectNotFound<THandleType> : EObjectNotFound<THandleType>
  {
    public EDependencyObjectNotFound(THandleType obj) : base(obj) { }
  }

  [Serializable]
  public class EDependencyNotFound<THandleType> : EDisposeHelper
  {
    public EDependencyNotFound(THandleType obj) : base(string.Format("Dependency not found ({0})", obj)) { }
  }

  [Serializable]
  public class EObjectAlreadyExists<THandleType> : EDisposeHelper
  {
    public EObjectAlreadyExists(THandleType obj) : base(string.Format("Object already exists ({0})", obj)) { }
  }

  [Serializable]
  public class EObjectDependencyAlreadyExists<THandleType> : EDisposeHelper
  {
    public EObjectDependencyAlreadyExists(THandleType obj) : base(string.Format("Dependency already exists ({0})", obj)) { }
  }
}