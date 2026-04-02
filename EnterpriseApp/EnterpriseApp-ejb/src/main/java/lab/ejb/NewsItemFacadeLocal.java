package lab.ejb;

import jakarta.ejb.Local;

import java.util.List;

@Local
public interface NewsItemFacadeLocal {
    public default List<NewsItem> getAllNewsItems() {
        return List.of();
    }
}
