import { DocumentViewerPage } from './app.po';

describe('document-viewer App', () => {
  let page: DocumentViewerPage;

  beforeEach(() => {
    page = new DocumentViewerPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
